<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Apresenracao_Web._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <link type="text/css" rel="stylesheet" href="Content/bootstrap.css" />
</head>
    <script src="Scripts/jquery-1.9.1.min.js"></script> 
    <script src="Scripts/bootstrap.min.js"></script> 
<body>
    <form id="form1" runat="server" class="well">
     <img src="images/mac.png" class="img-rounded" />
    <div>
       <p>Bem-Vindo, para acessar o conteúdo você precisa se autenticar</p>
      
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

       <div class="control-group">
           <label class="control-label" for="inputEmail">Email</label>
            <div class="controls">
                <input type="text" id="inputEmail" placeholder="Email">
             </div>
       </div>
       <div class="control-group">
          <label class="control-label" for="inputPassword">Senha</label>
             <div class="controls">
                <input type="password" id="inputPassword" placeholder="Password">
             </div>
       </div>
       <div class="control-group">
           <div class="controls">
             <label class="checkbox">
               <input type="checkbox"> lembrar-me</input>
                 
             </label>
             <button type="submit" class="btn btn-small btn-primary">Login</button>
             <button type="submit" class="btn btn-danger">Cancela</button>
           </div>
        </div> 
    </div>
    </form>
</body>
</html>
    
    </form>
</body>
</html>
