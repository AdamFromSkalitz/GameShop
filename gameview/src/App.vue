<template>
  <div id="app">
    <b-navbar toggleable="lg" type="dark" variant="info">
      <b-nav-item href="#">
        <router-link class="home" to="/">Home</router-link>
      </b-nav-item>
      <b-nav-item href="#">
        <router-link class="home" to="/add">Add</router-link>
      </b-nav-item>
    </b-navbar>
    <img alt="Vue logo" src="./assets/logo.png">
    <router-view></router-view>
  </div>
</template>

<script>

export default {
  name: 'App',
  components: {
    
  }
}
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
}
.home {
  text-decoration: none;
  color: white;
}
body {margin: 0;}
</style>
