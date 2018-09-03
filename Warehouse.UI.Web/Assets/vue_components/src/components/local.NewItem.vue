<template>
  <div>
   
  </div>
</template>

<script>
export default {
 name: "NewItem",
 props :{        
        ItemNumber :{
          type:string,
          default: ""
        },
         Location:{
           type:string,
           default: ""
         } ,
         Description:{
           type:string,
           default: ""
         },
         PartNumber:{
           type:string,
           default: ""
         },
         VendorId:{
           type:int,
           default: 0
         } ,
         VendorName:{
           type:string,
           default: ""
         },
         CategoryID :{
            type:int,
           default: 0
         },
         DescriptionCategory:{
          type:string,
           default: ""
         },
         UM:{
           type:string,
           default: ""
         },
         Quantity:{
           type:int,
           default: 0
         },
         Max :{
           type:int,
           default: 0
         },
         Min:{
           type:int,
           default: 0
         },
         DateCreated:{
           type:string,
           default: ""
         },
         DateModified:{
           type:string,
           default: ""
         },
         Username:{
           type:string,
           default: ""
         },     
         Company:{
            type:string,
            default: ""
         }
 }
}
</script>

