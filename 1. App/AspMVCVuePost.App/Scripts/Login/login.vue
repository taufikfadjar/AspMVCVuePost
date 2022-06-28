<template>
    <main>
        <HeaderComponent></HeaderComponent>

        <form class="form-signin">

            <b-alert v-show="showMessages" variant="danger" dismissible>
                Dismissible Alert!
            </b-alert>


            <b-button @click="showMessages=true" variant="info" class="m-1">
                Show dismissible alert ({{ showMessages ? 'visible' : 'hidden' }})
            </b-button>

            <div class="alert alert-warning alert-dismissible fade show" role="alert">
                <strong>Holy guacamole!</strong> You should check in on some of those fields below.
                <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>
            </div>

            <h1 class="h3 mb-3 fw-normal">Please sign in</h1>

            <div class="form-floating">
                <input type="email" class="form-control" id="floatingInput" v-model="email" placeholder="name@example.com">
                <label for="floatingInput">Email address</label>
            </div>
            <div class="form-floating">
                <input type="password" class="form-control" id="floatingPassword" v-model="password" placeholder="Password">
                <label for="floatingPassword">Password</label>
            </div>

            <div class="mb-3"></div>

            <button class="w-100 btn btn-lg btn-primary" v-on:click.prevent="submitSignIn">Sign in</button>
            <p class="mt-5 mb-3 text-muted">© 2021</p>
        </form>
    </main>
</template>

<style>
    .form-signin {
        max-width: 330px;
        margin: auto;
        text-align:center;
        padding-top:20px;
    }
</style>

<script>

    import HeaderComponent from '../Shared/header.vue';
    import axios from 'axios';

    export default {
        name: "login-component",
        components: {
            HeaderComponent
        },
        data : {
            email: "",
            password: "",
            alertMessages: "aaaa",
            showMessages: false
        },
        props: {
            baseUrl: String
        },
        methods: {
            submitSignIn: function () {
                axios.post(this.baseUrl+"login/SubmitLogin", { email: this.email, password : this.password })
                    .then(
                        response => {
                            console.log(response.data);

                            if (response.data.Success) {
                                location.href = response.data.Url;
                            } else {
                                this.alertMessages = response.data.Messages;
                                this.showMessages = !this.showMessages;

                            }
                        }

                );
                
            },
            dismissed() {
                console.log("Hello");
                this.showMessages = false;
            }
        }
    }
</script>

