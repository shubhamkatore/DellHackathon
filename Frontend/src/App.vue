<template>
  <div id="app">
    <nav class="navbar" role="navigation" aria-label="main navigation">
      <div class="navbar-brand">
        <a class="navbar-item" href="/">
          <label>Europian Restaurants</label>
        </a>
        
        <a
          role="button"
          class="navbar-burger burger"
          aria-label="menu"
          aria-expanded="false"
          data-target="navbarBasicExample"
        >
          <span aria-hidden="true"></span>
          <span aria-hidden="true"></span>
          <span aria-hidden="true"></span>
        </a>
      </div>

      <div id="navbarBasicExample" class="navbar-menu">
        <div class="navbar-start">
          <a class="navbar-item" href="http://shubhamkatore.com/" target="_blank">Portfolio</a>
          
          <a
            class="navbar-item"
            href="https://www.linkedin.com/in/shubhamkatore"
            target="_blank"
          >LinkedIn</a>
        </div>
      </div>
    </nav>

    <router-view/>
  </div>
</template>

<style lang="scss">
</style>
