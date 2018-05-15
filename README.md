"# dotnetapicore" 
项目基于此实例进行试验
https://www.cnblogs.com/landeanfen/p/5501490.html

测试 自定义路由
url:  http://localhost:57144/actionapi/Products/GetProduct/1
result: 
<Product xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/ProductsApp.Models">
<Category>Groceries</Category>
<Id>1</Id>
<Name>Tomato Soup</Name>
<Price>1</Price>
</Product>

url: http://localhost:57144/testapi/Products/aa/1
result: 
<Product xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.datacontract.org/2004/07/ProductsApp.Models">
<Category>Groceries</Category>
<Id>1</Id>
<Name>Tomato Soup</Name>
<Price>1</Price>
</Product>


