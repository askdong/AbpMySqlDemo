# AbpMySqlDemo
the lastest aspnetboilerplate with mysql ef

aspnetboilerplate 这算dotnet上最佳实践的模板了吧，但对其它数据库还不是特别友好，mysql的demo也没及时更新，通过最新的版本3.8来修改支持mysql，
用的还是ef db first ,不想写太多的实体类，应付快速开发原型,当然这不是最好的数据操作方式，但是：快！！

用mysql要生成DbContext及实体例，有两个库：Pomelo.EntityFrameworkCore.MySql，MySql.Data.EntityFrameworkCore
后者是官方的，但居然Scaffold-DbContext 会报错，没办法，只能用前面一个。


