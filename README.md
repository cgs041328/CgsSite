# cgssite
个人网站<br/>
结构：<br/>
  Cgssite.web:表现层<br/>
  Cgssite.Application:应用层，为表现层提供调用领域层的接口<br/>
  Cgssite.Domain:领域层，包含领域实体，领域实体工厂，以及repository的接口定义<br/>
  Cgssite.Insfracture：基础结构层，包含与业务逻辑无关的一些功能，如repository的具体实现<br/>
  Cgssite.Unittest: 一些单元测试<br/>
工具:<br/>
  前端：asp.net mvc5，Bootstrap，MvcSitemapProvider，TinyMCE<br/>
  IOC容器：AutoFac<br/>
  ORM：目前使用的是Entityframework 6(Code First)<br/>
  数据库：目前使用Sql Server 2012<br/>
  IDE:Visual Studio 2013 Comunity<br/>
