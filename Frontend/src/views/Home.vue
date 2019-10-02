<template>
  <div class="home">
    <div class="extras">
      <b-autocomplete
        :class="'autocomp'"
        rounded
        v-model="name"
        :data="filteredDataArray"
        placeholder="Type hotel name"
        @select="option => selected = option"
      >
        <template slot="empty">No results found</template>
      </b-autocomplete>
      <button class="button is-primary" @click="search()">Search</button>
      <br>
      <i class="fas fa-filter"></i>
      <div class="sorting">
        <label>Sort by User Rating</label>
        <i class="fas fa-sort-up" @click="sort(1)"></i>
        <i class="fas fa-sort-down" @click="sort(0)"></i>
      </div>
    </div>
    <Hotel
      v-for="(hotel,index) in hotelsData"
      :name="hotel.Name"
      :cuisine="getCuisine(hotel.Cuisine_Style)"
      :city="hotel.City"
      :ratings="hotel.Rating"
      :reviews="hotel.Number_of_Reviews"
      :key="index"
    ></Hotel>
  </div>
</template>

<script>
// @ is an alias to /src
import Hotel from "@/components/Hotel.vue";
import axios from "axios";
var apiUrl = "http://dellemc.azurewebsites.net/api/";

export default {
  name: "home",
  data() {
    return {
      hotelsData: null,
      hotels: null,
      name: "",
      data: ["abc", "bcd"]
    };
  },
  computed: {
    filteredDataArray() {
      return this.data.filter(option => {
        return (
          option
            .toString()
            .toLowerCase()
            .indexOf(this.name.toLowerCase()) >= 0
        );
      });
    }
  },
  mounted() {
    var myData = this;
    axios.get(apiUrl + "hotel").then(function(response) {
      if (response.data) {
        myData.hotels = response.data;
        myData.hotelsData = response.data;
      }
    });
  },
  components: {
    Hotel
  },
  methods: {
    sort(direction) {
      if (direction == 0)
        this.hotels.sort(function(a, b) {
          return a.Rating - b.Rating;
        });
      else
        this.hotels.sort(function(a, b) {
          return b.Rating - a.Rating;
        });
    },
    search() {
      if (this.name) {
        var myData = this;
        axios.get(apiUrl + "hotel/" + this.name).then(function(response) {
          if (response.data) myData.hotelsData = response.data;
        });
      } else this.hotelsData = this.hotels;
    },
    getCuisine(Cuisine) {
      return Cuisine.replace(/\[|]|'/g, "");
    }
  }
};
</script>
<style>
.autocomp {
  max-width: 50%;
}
.extras {
  display: flex;
}
.sorting {
  margin: 10px;
}
</style>

