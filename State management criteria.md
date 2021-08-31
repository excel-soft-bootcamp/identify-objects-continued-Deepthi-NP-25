# State management options <br>

|criteria|ViewState|SessionState|
|--------|---------|------------|
|Storage|Client Side|Server Side|
|Secured|By default serialized into a base-64 encoded string|Unless server is hacked session variables are safe|
|Size|Default size is 4mb|Max size is 10-20KB|
