<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pagina_Teste.aspx.cs" Inherits="Apresenracao_Web.Pagina_Teste" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
  <head>
    <meta charset="utf-8" />
    <title>
    </title>
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <meta name="description" content="" />
    <meta name="author" content="" />
    <!-- Le styles -->
     <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
    <script src="Scripts/jquery-1.9.1.min.js"></script> 
    <script src="Scripts/bootstrap.min.js"></script>  
    <style>
      body { padding-top: 60px; /* 60px to make the container go all the way
      to the bottom of the topbar */ }
    </style>
    <!-- Le HTML5 shim, for IE6-8 support of HTML5 elements -->
    <!--[if lt IE 9]>
      <script src="http://html5shim.googlecode.com/svn/trunk/html5.js">
      </script>
    <![endif]-->
    <!-- Le fav and touch icons -->
    <link rel="shortcut icon" href="images/favicon.ico" />
    <link rel="apple-touch-icon-precomposed" sizes="144x144" href="images/apple-touch-icon-144-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="114x114" href="images/apple-touch-icon-114-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" sizes="72x72" href="images/apple-touch-icon-72-precomposed.png" />
    <link rel="apple-touch-icon-precomposed" href="images/apple-touch-icon-57-precomposed.png" />
    <style>
    </style>
  </head>
  <body>
    <div class="navbar navbar-fixed-top navbar-inverse">
      <div class="navbar-inner">
        <div class="container">
          <a id="titulo1" class="brand" href="http://www.macoratti.net">
            Macoratti.net
          </a>
          <ul class="nav">
            <li>
              <a href="http://www.macoratti.net">
                Home
              </a>
            </li>
            <li>
              <a href="http://www.macoratti.net/objetivo.aspx">
                Sobre
              </a>
            </li>
            <li>
              <a href="matilto:macoratti@yahoo.com">
                Contato
              </a>
            </li>
          </ul>
          <form class="navbar-form pull-right">
            <input name="textinput1" placeholder="Email" class="span2" type="email" />
            <input name="textinput2" placeholder="Password" class="span2" type="password" />
            <button class="btn">
              Logar
            </button>
          </form>
        </div>
      </div>
    </div>
    <div id="macsite" class="container-fluid macsite">
      <div class="hero-unit">
        <img id="img1" class="img1" src="images/mac.png" style=" width: 250px; height: 50px;" />
        <div id="pag1" class="pag1">
        </div>
        <a id="bot1" class="btn btn-primary bot1" href="http://www.macoratti.net">
          Aprenda mais »
        </a>
      </div>
      <div class="row">
        <div class="span4">
          <div id="head1" class="head1">
            <h2>
              VB .NET
            </h2>
            <p>
              &nbsp;
            </p>
          </div>
          <a id="deta1" class="btn deta1" href="http://www.macoratti.net/pageview.aspx?catid=1">
            Detalhes »
          </a>
        </div>
        <div class="span4">
          <div id="head2" class="head2">
            <h2>
              C#
            </h2>
            <p>
              &nbsp;
            </p>
          </div>
          <a id="deta2" class="btn deta2" href="http://www.macoratti.net/pageview.aspx?catid=18">
            Detalhes »
          </a>
        </div>
        <div class="span4">
          <div id="head3" class="head3">
            <h2>
              ASP .NET
            </h2>
            <p>
              &nbsp;
            </p>
          </div>
          <a id="deta3" class="btn deta3" href="http://www.macoratti.net/pageview.aspx?catid=3">
            Detalhes »
          </a>
        </div>
      </div>
      <hr>
      <div>
        © Macoratti 2013
      </div>
    </div>
  </body>
</html>
