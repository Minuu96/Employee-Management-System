const API_BASE = 'http://localhost:5199/api';

// --- UI STATE ---
let currentUser = null;

// --- DOM ELEMENTS ---
const authContainer = document.getElementById('auth-container');
const appContainer = document.getElementById('app-container');
const loginBox = document.querySelector('.login-box');
const registerBox = document.querySelector('.register-box');
const sidebarUsername = document.getElementById('sidebar-username');
const pageTitle = document.getElementById('page-title');
const navBtns = document.querySelectorAll('.nav-btn');
const views = document.querySelectorAll('.view');
const toastContainer = document.getElementById('toast-container');

// --- INIT ---
document.addEventListener('DOMContentLoaded', () => {
    // Show Auth
    authContainer.style.display = 'flex';
    appContainer.style.display = 'none';

    // Auth Toggles
    document.getElementById('link-to-register').addEventListener('click', (e) => {
        e.preventDefault();
        loginBox.classList.remove('active');
        registerBox.classList.add('active');
    });
    document.getElementById('link-to-login').addEventListener('click', (e) => {
        e.preventDefault();
        registerBox.classList.remove('active');
        loginBox.classList.add('active');
    });

    // Password Toggles
    document.querySelectorAll('.toggle-pass').forEach(btn => {
        btn.addEventListener('click', (e) => {
            const input = e.currentTarget.previousElementSibling;
            const icon = e.currentTarget.querySelector('i');
            if(input.type === 'password') {
                input.type = 'text';
                icon.classList.replace('bx-hide', 'bx-show');
            } else {
                input.type = 'password';
                icon.classList.replace('bx-show', 'bx-hide');
            }
        });
    });

    // Navigation
    navBtns.forEach(btn => {
        btn.addEventListener('click', () => {
            const target = btn.getAttribute('data-target');
            switchView(target);
            navBtns.forEach(b => b.classList.remove('active'));
            btn.classList.add('active');
        });
    });

    // Logout
    document.getElementById('logout-btn').addEventListener('click', () => {
        currentUser = null;
        appContainer.style.display = 'none';
        authContainer.style.display = 'flex';
        showToast('Logged out successfully', 'success');
        document.getElementById('login-form').reset();
    });

    // Forms
    document.getElementById('login-form').addEventListener('submit', handleLogin);
    document.getElementById('register-form').addEventListener('submit', handleRegister);
    document.getElementById('btn-add-emp').addEventListener('click', handleAddEmployee);
    document.getElementById('btn-update-emp').addEventListener('click', handleUpdateEmployee);
    document.getElementById('btn-delete-emp').addEventListener('click', handleDeleteEmployee);
    document.getElementById('btn-clear-emp').addEventListener('click', clearEmpForm);
    document.getElementById('btn-update-salary').addEventListener('click', handleUpdateSalary);
    document.getElementById('btn-clear-salary').addEventListener('click', clearSalaryForm);
    
    // Theme setup
    document.getElementById('theme-toggle').addEventListener('click', () => {
        showToast('Minimalist theme active.', 'info');
    });
});

// --- HELPERS ---
function showToast(msg, type = 'info') {
    const toast = document.createElement('div');
    toast.className = `toast ${type}`;
    let icon = 'bx-info-circle';
    if(type === 'success') icon = 'bx-check-circle';
    if(type === 'error') icon = 'bx-error-circle';
    
    toast.innerHTML = `<i class='bx ${icon}'></i><p>${msg}</p>`;
    toastContainer.appendChild(toast);
    
    setTimeout(() => {
        toast.style.animation = 'fadeOut 0.3s forwards';
        setTimeout(() => toast.remove(), 300);
    }, 3000);
}

function switchView(viewId) {
    views.forEach(v => v.classList.remove('active'));
    document.getElementById(`view-${viewId}`).classList.add('active');
    pageTitle.textContent = viewId.charAt(0).toUpperCase() + viewId.slice(1);
    
    if(viewId === 'dashboard') loadDashboardStats();
    if(viewId === 'employees') loadEmployees();
    if(viewId === 'salary') loadSalaryTable();
}

// --- AUTH API ---
async function handleLogin(e) {
    e.preventDefault();
    const user = document.getElementById('login-user').value;
    const pass = document.getElementById('login-pass').value;

    try {
        const res = await fetch(`${API_BASE}/auth/login`, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ Username: user, Password: pass })
        });
        const data = await res.json();
        
        if(res.ok && data.success) {
            currentUser = user;
            sidebarUsername.textContent = user;
            authContainer.style.display = 'none';
            appContainer.style.display = 'grid';
            showToast(data.message, 'success');
            switchView('dashboard');
        } else {
            showToast(data.message || 'Login failed', 'error');
        }
    } catch(err) {
        showToast('Server connection failed.', 'error');
    }
}

async function handleRegister(e) {
    e.preventDefault();
    const user = document.getElementById('reg-user').value;
    const pass = document.getElementById('reg-pass').value;

    try {
        const res = await fetch(`${API_BASE}/auth/register`, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ Username: user, Password: pass })
        });
        const data = await res.json();
        
        if(res.ok && data.success) {
            showToast(data.message, 'success');
            document.getElementById('link-to-login').click(); // switch to login
        } else {
            showToast(data.message || 'Registration failed', 'error');
        }
    } catch(err) {
        showToast('Server connection failed.', 'error');
    }
}

// --- DASHBOARD API ---
async function loadDashboardStats() {
    try {
        const res = await fetch(`${API_BASE}/dashboard/stats`);
        if(!res.ok) return;
        const stats = await res.json();
        document.getElementById('stat-total').textContent = stats.total;
        document.getElementById('stat-active').textContent = stats.active;
        document.getElementById('stat-inactive').textContent = stats.inactive;
    } catch(err) {
        console.error('Stats loading failed', err);
    }
}

// --- EMPLOYEE API ---
async function loadEmployees() {
    try {
        const res = await fetch(`${API_BASE}/employee`);
        if(!res.ok) return;
        const emps = await res.json();
        renderEmployeeTable(emps);
    } catch(err) {
        console.error('Employees load failed', err);
    }
}

function renderEmployeeTable(emps) {
    const tbody = document.querySelector('#employees-table tbody');
    tbody.innerHTML = '';
    emps.forEach(emp => {
        const tr = document.createElement('tr');
        tr.innerHTML = `
            <td>${emp.employeeId}</td>
            <td style="font-weight: 500; color: var(--text-primary);">${emp.fullName}</td>
            <td>${emp.gender}</td>
            <td>${emp.contactNum}</td>
            <td>${emp.position}</td>
            <td><span class="badge badge-${emp.status.toLowerCase()}">${emp.status}</span></td>
        `;
        tr.addEventListener('click', () => populateEmpForm(emp, tr));
        tbody.appendChild(tr);
    });
}

function populateEmpForm(emp, tr) {
    document.querySelectorAll('#employees-table tr').forEach(row => row.classList.remove('selected'));
    if(tr) tr.classList.add('selected');

    document.getElementById('emp-id').value = emp.employeeId;
    document.getElementById('emp-name').value = emp.fullName;
    document.getElementById('emp-gender').value = emp.gender;
    document.getElementById('emp-contact').value = emp.contactNum;
    document.getElementById('emp-position').value = emp.position;
    document.getElementById('emp-status').value = emp.status;
}

function clearEmpForm() {
    document.getElementById('employee-form').reset();
    document.querySelectorAll('#employees-table tr').forEach(row => row.classList.remove('selected'));
}

async function handleAddEmployee() {
    const data = getEmpFormData();
    if(!data.EmployeeId || !data.FullName) {
        showToast('ID and Name are required', 'error'); return;
    }
    
    try {
        const res = await fetch(`${API_BASE}/employee`, {
            method: 'POST',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
        });
        const resData = await res.json();
        if(res.ok) {
            showToast(resData.message, 'success');
            clearEmpForm();
            loadEmployees();
        } else showToast(resData.message || 'Add Failed', 'error');
    } catch(e) { showToast('Connection failed', 'error'); }
}

async function handleUpdateEmployee() {
    const data = getEmpFormData();
    if(!data.EmployeeId) return showToast('Select an employee first', 'error');
    
    try {
        const res = await fetch(`${API_BASE}/employee/${data.EmployeeId}`, {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify(data)
        });
        const resData = await res.json();
        if(res.ok) {
            showToast(resData.message, 'success');
            loadEmployees();
        } else showToast(resData.message || 'Update Failed', 'error');
    } catch(e) { showToast('Connection failed', 'error'); }
}

async function handleDeleteEmployee() {
    const id = document.getElementById('emp-id').value;
    if(!id) return showToast('Select an employee first', 'error');
    
    try {
        const res = await fetch(`${API_BASE}/employee/${id}`, { method: 'DELETE' });
        const resData = await res.json();
        if(res.ok) {
            showToast(resData.message, 'success');
            clearEmpForm();
            loadEmployees();
        } else showToast(resData.message, 'error');
    } catch(e) { showToast('Connection failed', 'error'); }
}

function getEmpFormData() {
    return {
        EmployeeId: document.getElementById('emp-id').value,
        FullName: document.getElementById('emp-name').value,
        Gender: document.getElementById('emp-gender').value,
        ContactNum: document.getElementById('emp-contact').value,
        Position: document.getElementById('emp-position').value,
        Status: document.getElementById('emp-status').value,
        Image: ''
    };
}

// --- SALARY API ---
async function loadSalaryTable() {
    try {
        const res = await fetch(`${API_BASE}/employee`); // reuse endpoint for list
        if(!res.ok) return;
        const emps = await res.json();
        const tbody = document.querySelector('#salary-table tbody');
        tbody.innerHTML = '';
        emps.forEach(emp => {
            const tr = document.createElement('tr');
            tr.innerHTML = `
                <td>${emp.employeeId}</td>
                <td style="font-weight: 500; color: var(--text-primary);">${emp.fullName}</td>
                <td>${emp.position}</td>
                <td style="color: var(--success); font-weight: bold;">₹${emp.salary.toLocaleString()}</td>
            `;
            tr.addEventListener('click', () => populateSalaryForm(emp, tr));
            tbody.appendChild(tr);
        });
    } catch(err) { console.error('Salary load failed', err); }
}

function populateSalaryForm(emp, tr) {
    document.querySelectorAll('#salary-table tr').forEach(row => row.classList.remove('selected'));
    if(tr) tr.classList.add('selected');

    document.getElementById('sal-id').value = emp.employeeId;
    document.getElementById('sal-name').value = emp.fullName;
    document.getElementById('sal-position').value = emp.position;
    document.getElementById('sal-amount').value = emp.salary;
}

function clearSalaryForm() {
    document.getElementById('salary-form').reset();
    document.querySelectorAll('#salary-table tr').forEach(row => row.classList.remove('selected'));
}

async function handleUpdateSalary() {
    const id = document.getElementById('sal-id').value;
    const amount = document.getElementById('sal-amount').value;
    
    if(!id) return showToast('Select an employee first', 'error');
    if(!amount) return showToast('Enter a salary amount', 'error');
    
    try {
        const res = await fetch(`${API_BASE}/salary/${id}`, {
            method: 'PUT',
            headers: { 'Content-Type': 'application/json' },
            body: JSON.stringify({ EmployeeId: id, Salary: parseInt(amount) })
        });
        const resData = await res.json();
        if(res.ok) {
            showToast(resData.message, 'success');
            loadSalaryTable();
        } else showToast(resData.message, 'error');
    } catch(e) { showToast('Connection failed', 'error'); }
}
