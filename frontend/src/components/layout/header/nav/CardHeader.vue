
<template>
  <div class="contain">
    <form @change="formChange">
      <div class="card card-sobre">
        <div class="card-body">
          <div class="row">
            <div class="input-group col-4 col-md-3 mb-3 input-icon2 none">
              <div class="input-group-prepend">
                <span class="input-icon" id="basic-addon1">
                  <i class="material-icons">location_on</i>
                </span>
              </div>
              <input
                type="text"
                class="form-input"
                v-model="city_name"
                name="city_name"
                placeholder="Pick a city"
              >
            </div>

            <div class="input-group col-4 col-md-3 mb-3 input-icon2 none">
              <div class="input-group-prepend">
                <span class="input-icon" id="basic-addon1">
                  <i class="material-icons">calendar_today</i>
                </span>
              </div>

              <datepicker
                v-model="city_date"
                class="form-input date-input"
                name="city_date"
                style="border: none"
                format="MMM, dd,yyyy"
                :disabledDates="disabledDates"
              ></datepicker>
            </div>

            <div class="input-group col-4 col-md-2 mb-3 input-icon2 none">
              <div class="input-group-prepend">
                <span class="input-icon" id="basic-addon1">
                  <i class="material-icons">person</i>
                </span>
              </div>
              <select v-model="city_guest" class="form-input">
                <option
                  v-for="option in optionsGuest"
                  v-bind:key="option.value"
                  v-bind:value="option.value"
                >{{ option.text }}</option>
              </select>
            </div>

            <div class="input-group col-4 col-md-2 input-icon2 none">
              <div class="input-group-prepend">
                <span class="input-icon" id="basic-addon1">
                  <i class="material-icons">class</i>
                </span>
              </div>
              <select v-model="city_class" class="form-input">
                <option
                  v-for="option in optionsClass"
                  v-bind:key="option.value"
                  v-bind:value="option.value"
                >{{ option.text }}</option>
              </select>
            </div>

            <div class="input-group col-4 col-md-1 input-icon2 none">
              <div class="input-group-prepend">
                <span class="input-icon" id="basic-addon1">
                  <i class="material-icons">credit_card</i>
                </span>
              </div>
              <input
                type="number"
                class="form-input"
                v-model="city_cost"
                name="city_cost"
                placeholder="800"
              >
            </div>
          </div>
          <!-- row -->
        </div>
      </div>
    </form>
  </div>
</template>

<script>
import Datepicker from "vuejs-datepicker";
import moment from "moment";

export default {
  name: "CardHeader",
  components: {
    Datepicker
  },
  data() {
    return {
      city_guest: "1",
      city_class: "1",
      optionsGuest: [
        { text: "1 Guest", value: "1" },
        { text: "2 Guest", value: "2" },
        { text: "3 Guest", value: "3" },
        { text: "4 Guest", value: "4" },
        { text: "5 Guest", value: "5" },
        { text: "6 Guest", value: "6" },
        { text: "7 Guest", value: "7" },
        { text: "8 Guest", value: "8" }
      ],
      optionsClass: [
        { text: "First Class", value: "1" },
        { text: "Executive", value: "2" },
        { text: "Economic", value: "3" }
      ],
      city_name: "",
      city_date: new Date(),
      city_cost: 0,
      disabledDates: {
        to: new Date()
      }
    };
  },
  methods: {
    formChange(e) {
      e.preventDefault();

      const newSearch = {
        city_name: this.city_name,
        city_date: moment(new Date()).format("YYYY/MM/DD"),
        city_cost: this.city_cost,
        city_guest: parseInt(this.city_guest),
        city_class: parseInt(this.city_class)
      };
      this.$emit("search-trips", newSearch);
      console.log("emit");
    }
  }
};
</script>

<style scoped>
i {
  font-size: 16px !important;
}

.btn {
  font-size: 0.775rem;
  background: none;
}

.card-sobre {
  margin-top: -60px;
  z-index: 99;
  margin-bottom: 16px;
  box-shadow: 0px 1px 10px 0px #dddddd;
}

.card .card-body {
  border: none !important;
}

.input-icon {
  display: -ms-flexbox;
  display: flex;
  -ms-flex-align: center;
  align-items: center;
  padding: 0 0 0 0.25em;
  margin-bottom: 0;
  font-size: 0.775rem;
  font-weight: 400;
  line-height: 1.2;
  text-align: center;
  white-space: nowrap;
}
.input-group > .form-input {
  position: relative;
  -ms-flex: 1 1 auto;
  flex: 1 1 auto;
  width: 1%;
  margin-bottom: 0;
}
.form-input:after {
  position: absolute;
  content: "";
  top: 14px;
  right: 10px;
  width: 0;
  height: 0;
  border: 6px solid transparent;
  border-color: #fff transparent transparent transparent;
}
.form-input {
  display: block;
  width: 100%;
  height: calc(1.5em + 0.45rem + 2px);
  padding: 0 0 0 0.35em;
  font-size: 0.775rem;
  font-weight: 400;
  line-height: 1.5;
  border: none !important;
  margin-left: 2px;
}

.date-input {
  padding-top: 6px;
}

@media (min-width: 979px) {
  .input-icon2 {
    margin-bottom: 0 !important;
  }
}
</style>