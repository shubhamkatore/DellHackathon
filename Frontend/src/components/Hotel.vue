<template>
  <div class="card">
    <div class="card-content">
      <img class="hotellogo" src="../assets/Hotel.png">
      <div class="content">
        <label>{{name}}</label>
        <i class="fas fa-star rateicon" aria-hidden="true">{{ratings}}</i>
        <br>
        <label>{{cuisine}}</label>
        <br>
        <label>{{city}}</label>
      </div>
    </div>
    <footer class="card-footer">
      <span>{{reviews}} Reviews</span>
    </footer>
  </div>
</template>

<script>
// @ is an alias to /src
import "bulma";

export default {
  name: "Hotel",
  props: ["name", "cuisine", "city", "ratings", "reviews"],
  data() {
    return {};
  }
};
</script>

<style>
.hotellogo {
  max-height: 100px;
}
.card-content,
.content {
  display: inline;
}
.card {
  display: inline-block;
  min-width: 45%;
  max-width: 45%;
  margin: 10px;
}
.rateicon {
  float: right;
}
</style>

