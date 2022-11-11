<template>
  <div id="app">
    <header>
      <b-navbar toggleable="md" type="light">
        <b-navbar-toggle target="nav-collapse"></b-navbar-toggle>
        <b-navbar-brand to="/">eTimesheet</b-navbar-brand>
        <b-collapse is-nav id="nav-collapse">
          <b-navbar-nav>
            <b-nav-item to="/add-project">Add Project</b-nav-item>
            <b-nav-item to="/project-teams">Project Teams</b-nav-item>
            <b-nav-item to="/time-sheet">Timesheet</b-nav-item>
          </b-navbar-nav>
        </b-collapse>
      </b-navbar>
    </header>
    <!-- <h1> <img src="@/assets/logo.png" alt=""></h1> -->
    <main>
      <router-view></router-view>
    </main> 
  </div>
</template>

<script>

  export default {
    data () {
      return {
      }
 
    }
  }
</script>

<style>
h1{
  text-align: center;
  margin-top: 40px;
}

body {
  margin: 0;
}

#app {
  font-family: 'Avenir', Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  color: #28C69F; ;
}

main {
  text-align: center;
  margin-top: 40px;
}

header {
  margin: 0;
  height: 56px;
  padding: 0 16px 0 24px;
  background-color: #28C69F; ;
  color: #28C69F; ;
}

header span {
  display: block;
  position: relative;
  font-size: 20px;
  line-height: 1;
  letter-spacing: .02em;
  font-weight: 400;
  box-sizing: border-box;
  padding-top: 16px;
}
</style>