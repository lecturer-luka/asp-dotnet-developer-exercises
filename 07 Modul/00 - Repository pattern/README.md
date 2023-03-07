<div align="center">

<!-- title -->

# Basic exercises for Repository pattern classes and interfaces in Web App ASP.NET MVC

<!-- description -->

The exercise set cover the most basic ways of possible model classes with properties, controller classes with actions, repository classes and view names for a web applications using the repository pattern in C#.

</div>


## Exercise 1

1. Create a new ASP.NET Core MVC application using Visual Studio or the Visual Studio Code.
2. Exercise is to create simple "CRUD" beauty shop web application using the repository pattern in C#.
3. Create model classes:
	* Customer
		* Id (int)
        * Name (string)
        * Email (string)
        * Phone (string)
        * Address (string)

    * Product
        * Id (int)
        * Name (string)
        * Description (string)
        * Price (decimal)

    * Order
        * Id (int)
        * OrderDate (DateTime)
        * TotalAmount (decimal)
        * CustomerId (int)

    * OrderItem
        * Id (int)
        * Quantity (int)
        * ProductId (int)
        * OrderId (int)

4. Create Controller classes:
    * CustomerController
        * Index()
        * Create()
        * Edit(int id)
        * Edit(int id, Customer customer)
        * Delete(int id)
        * DeleteConfirmed(int id)

    * ProductController
        * Index()
        * Create()
        * Edit(int id)
        * Edit(int id, Product product)
        * Delete(int id)
        * DeleteConfirmed(int id)

    * OrderController
        * Index()
        * Create()
        * Edit(int id)
        * Edit(int id, Order order)
        * Delete(int id)
        * DeleteConfirmed(int id)

5. Create interfaces for repository classes:
    * ICustomerRepository
        * IEnumerable<Customer> GetCustomers()
        * Customer GetCustomerById(int id)
        * void AddCustomer(Customer customer)
        * void UpdateCustomer(Customer customer)
        * void DeleteCustomer(int id)

    * IProductRepository
        * IEnumerable<Product> GetProducts()
        * Product GetProductById(int id)
        * void AddProduct(Product product)
        * void UpdateProduct(Product product)
        * void DeleteProduct(int id)

    * IOrderRepository
        * IEnumerable<Order> GetOrders()
        * Order GetOrderById(int id)
        * void AddOrder(Order order)
        * void UpdateOrder(Order order)
        * void DeleteOrder(int id)
        * IEnumerable<OrderItem> GetOrderItemsByOrderId(int orderId)
        * void AddOrderItem(OrderItem orderItem)
6. Create Repository classes that inherit above interfaces.
7. Create Views:
    * Customer
        * Index.cshtml
        * Create.cshtml
        * Edit.cshtml
        * Delete.cshtml

    * Product
        * Index.cshtml
        * Create.cshtml
        * Edit.cshtml
        * Delete.cshtml

    * Order
        * Index.cshtml
        * Create.cshtml
        * Edit.cshtml
        * Delete.cshtml
        * OrderItems.cshtml
8. Based on the given suggestions, create a functional web application that will store data in memory or external ".json" file.
    > Entity Framework will be covered in the module 8.
