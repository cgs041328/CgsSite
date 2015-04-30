# cgssite
个人网站
结构：
  Cgssite.web:表现层;
  Cgssite.Application:应用层，为表现层提供调用领域层的接口;
  Cgssite.Domain:领域层，包含领域实体，领域实体工厂，以及respository的接口定义;
  Cgssite.Insfracture：基础结构层，包含与业务逻辑无关的一些功能，如respository的具体实现；
  Cgssite.Unittest: 一些单元测试
工具：
  前端：asp.net mvc5，Bootstrap，MvcSitemapProvider，TinyMCE;
  IOC容器：AutoFac;
  ORM：目前使用的是Entityframework 6（Code First）;
  数据库：目前使用Sql Server 2012;
  IDE:Visual Studio 2013 Comunity
