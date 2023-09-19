<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminRegister.aspx.cs" Inherits="LeaveManagementSystem.AdminRegister" %>

<!DOCTYPE html>

<!DOCTYPE html>

<html lang="en">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
    <title>Admin Registration Page</title>

    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/bundles/modernizr") %>
    </asp:PlaceHolder>

    <webopt:bundlereference runat="server" path="~/Content/css" />
    <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />

    <style>
    body {
    color: #000;
    overflow-x: hidden;
    height: 100%;
    background-color: #B0BEC5;
    background-repeat: no-repeat
}

.card0 {
    box-shadow: 0px 4px 8px 0px #757575;
    border-radius: 0px
}

.card2 {
    margin: 0px 40px
}

.logo {
    width: 200px;
    height: 100px;
    margin-top: 20px;
    margin-left: 35px
}

.image {
    width: 360px;
    height: 280px
}

.border-line {
    border-right: 1px solid #EEEEEE
}


.line {
    height: 1px;
    width: 45%;
    background-color: #E0E0E0;
    margin-top: 10px
}

.or {
    width: 10%;
    font-weight: bold
}

.text-sm {
    font-size: 14px !important
}

::placeholder {
    color: #BDBDBD;
    opacity: 1;
    font-weight: 300
}

:-ms-input-placeholder {
    color: #BDBDBD;
    font-weight: 300
}

::-ms-input-placeholder {
    color: #BDBDBD;
    font-weight: 300
}

input,
textarea {
    padding: 10px 12px 10px 12px;
    border: 1px solid lightgrey;
    border-radius: 2px;
    margin-bottom: 5px;
    margin-top: 2px;
    width: 100%;
    box-sizing: border-box;
    color: #2C3E50;
    font-size: 14px;
    letter-spacing: 1px
}

input:focus,
textarea:focus {
    -moz-box-shadow: none !important;
    -webkit-box-shadow: none !important;
    box-shadow: none !important;
    border: 1px solid #304FFE;
    outline-width: 0
}

button:focus {
    -moz-box-shadow: none !important;
    -webkit-box-shadow: none !important;
    box-shadow: none !important;
    outline-width: 0
}

a {
    color: inherit;
    cursor: pointer
}

.btn-blue {
    background-color: #1A237E;
    width: 150px;
    color: #fff;
    border-radius: 2px
}

.btn-blue:hover {
    background-color: #000;
    cursor: pointer
}

.bg-blue {
    color: #fff;
    background-color: #1A237E
}

@media screen and (max-width: 991px) {
    .logo {
        margin-left: 0px
    }

    .image {
        width: 300px;
        height: 220px
    }

    .border-line {
        border-right: none
    }

    .card2 {
        border-top: 1px solid #EEEEEE !important;
        margin: 0px 15px
    }
}

/*for high definition screens*/
@media only screen and (min-width: 1400px){
    div.topSpacing{
        margin-top:-700px;
    }
}

</style>

</head>

     <html xmlns="http://www.w3.org/1999/xhtml">

<body>

      <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.1.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-U1DAWAznBHeqEIlVSCgzq+c9gqGAJn5c/t99JyeKa9xxaYpSvHU5awsuZVVFIhvj" crossorigin="anonymous"></script> 
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script> 

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.0/js/bootstrap.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/ekko-lightbox/5.3.0/ekko-lightbox.js"></script>

    <form id="form1" runat="server">

          <!--navbar-->
        <div class="banner-area">
            <div class="container">
                <div class="row">
                    <div class="col-12">
      <nav class="navbar navbar-expand-lg navbar-dark bg-dark rounded">
  <div class="container-fluid">
    <div class="navbar-brand" href="#" style="font-size:large">
        Leave Management System / Admin Registration
    </div>
     </div>

        <div class="nav-item me-0">
            <asp:Label ID="label1" runat="server" style="font-size:x-large" BorderStyle="None" ForeColor="DarkGray"></asp:Label>
        </div>
        
     <!--   <input class="form-control me-2" type="search" placeholder="Search" aria-label="Search">
        <button class="btn btn-outline-success" type="submit">Search</button>  -->
      </div> 
    </div>
  </div>
</nav>
                    </div>
        <!--end of navbar-->
        
          <!--start of the form-->
       <div class="container-fluid px-1 px-md-5 px-lg-1 px-xl-5 py-5 mx-auto topSpacing">
    <div class="card card0 border-0">
        <div class="row d-flex">
            <div class="col-lg-6">
                <div class="card1 pb-5">
                    
                    <div class="row px-3 justify-content-center mt-4 mb-5 border-line"> <img src="https://i.imgur.com/uNGdWHi.png" class="image"> </div>
                </div>
            </div>
            <div class="col-lg-6">
                <iv class="card2 card border-0 px-4 py-5">
                   
                    <div class="row px-3 mb-4">
                      <!--  <div class="line"></div> <small class="or text-center">Or</small>
                        <div class="line"></div> -->
                        <h3 class="text-center font-weight-bold">Please enter your details below and click "Register" if you are not registered or 
                            click Log In to proceed to your leave entry page!
                        </h3>
                    </div>
                    
                    <div class="row px-3 mb-4">
                        <asp:Label ID="label2" runat="server" style="font-size:x-large" BorderStyle="None" ForeColor="DarkGray"></asp:Label>
                    </div>
                    
                    <div class="row px-3"> <label class="mb-1">
                            <h6 class="mb-0 text-sm">Username</h6>
                        </label> <input class="mb-4" type="text" name="username" placeholder="Enter your username"> 
                    </div>

                    <div class="row px-3"> <label class="mb-1">
                            <h6 class="mb-0 text-sm">Password</h6>
                        </label> <input type="text" name="password" placeholder="Enter your password"> 
                    </div>
                   
                       
                    <div class="row mb-3 px-3"> <!--<button type="submit" class="btn btn-blue text-center">Login</button> -->
                        <asp:Button ID="Button2" runat="server" CssClass="btn btn-blue text-center"
                            Text="Register" OnClick="Button2_Click1"></asp:Button>
                    </div>   
                    
                    <div class="row mb-3 px-3"> <!--<button type="submit" class="btn btn-blue text-center">Login</button> -->
                        <asp:Button ID="Button1" runat="server" CssClass="btn btn-blue text-center"
                            Text="Log In" OnClick="Button1_Click1"></asp:Button>
                    </div>      
                       
                    <div class="row mb-3 px-3"> <!--<button type="submit" class="btn btn-blue text-center">Login</button> -->
                        
                    </div>                  
                </div>
            </div>
        </div>
     
    </div>

    </form>
</body>
</html>

<body>
        
        <div class="container body-content">
           
          </div>
    </form>
    <asp:PlaceHolder runat="server">
        <%: Scripts.Render("~/Scripts/bootstrap.js") %>
    </asp:PlaceHolder>
</body>
</html>

