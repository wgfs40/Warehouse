<template>
  <div>       
      <div class="form-group">
          <label>Nombre del vendedor</label>
          <input type="text" class="form-control" name="vendorName" /> 
          <span class="input-group-addon"><icon name="code"></icon></span>
      </div>
  </div>
</template>

<script>
import icon from './global.icon.vue'
export default {
  components:{
    icon
  },
 name: "Vendor",
 props :{
         vendorId:{
           type:int,
           default: 0
         } ,
         vendorName:{
           type:string,
           default: ""
         }
  },
  mounted() {
    this.$parent.$on("vendorSelectedID", id =>{
      this.vendorId = id;
    })
  },
}
</script>

