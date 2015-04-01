# webapi-cors
A demo site for ASP.NET Web API CORS

* Access http://cors-webapi.azurewebsites.net/api/values from any origin.
* Here is a demo fiddle: http://jsfiddle.net/shaunluttin/Lbfk2ggu/

`
$.get( "http://cors-webapi.azurewebsites.net/api/values", function( data ) {
  $( ".result" ).html( data );
});
`
