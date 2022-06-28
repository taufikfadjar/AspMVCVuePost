
<template>
    <header class="p-3 bg-dark text-white">
        <div class="container">
            <div class="d-flex flex-wrap align-items-center justify-content-center justify-content-lg-start">
                <a href="/" class="d-flex align-items-center mb-3 mb-md-0 col-2 text-dark text-decoration-none">
                    <span class="fs-4 text-white">My Post</span>
                </a>

                <ul class="nav col-12 col-lg-auto me-lg-auto mb-2 mb-md-0">
                    <li><a href="#" class="nav-link px-2 text-secondary">Home</a></li>
                    <li><a href="#" class="nav-link px-2 text-white">Post</a></li>
                    <li><a href="#" class="nav-link px-2 text-white">User</a></li>
                </ul>

                <div class="text-end">
                    <button type="button" class="btn btn-warning">Login</button>
                </div>
            </div>
        </div>
    </header>


</template>

<script>
    export default {
        name : "header-component"
    }
</script>