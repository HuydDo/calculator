const button = document.getElementById("notify")
button.addEventListener('click', function(){
  console.log("printing a message")
})

button.addEventListener('mouseover', function(){
  console.log("Printing a Message!")
  
}) 


// document.addListenerEvent("DOMContentLoaded", function(){
//   const button = document.getElementById("notifliable")
//   button.addListenerEvent('click', function(){
//     console.log("Printing a Message!")
//   })
// }); 