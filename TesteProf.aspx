﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TesteProf.aspx.cs" Inherits="INfoEducatie.TesteProf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css"/>

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.2.1/jquery.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js"></script>
    <title>Home</title>
    <style>
        body {
            background-image: url("back.jpg");
        }
         
        .wb {
            background-color: white;
            border-radius: 10px;
        }

        .slideanim {
            visibility: hidden;
        }

        .slide {
            animation-name: slide;
            -webkit-animation-name: slide;
            animation-duration: 1s;
            -webkit-animation-duration: 1s;
            visibility: visible;
        }

        @keyframes slide {
            0% {
                opacity: 0;
                transform: translateY(70%);
            }

            100% {
                opacity: 1;
                transform: translateY(0%);
            }
        }

        @-webkit-keyframes slide {
            0% {
                opacity: 0;
                -webkit-transform: translateY(70%);
            }

            100% {
                opacity: 1;
                -webkit-transform: translateY(0%);
            }
        }
        .im{
            width:100%;
        }
    </style>
</head>
<body>
    <nav class="navbar navbar-default navbar-fixed-top">
        <div class="container">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target="#navb">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand" href="index.aspx">Math Evolved</a>
            </div>
            <div class="collapse navbar-collapse" id="navb">
                <ul class="nav navbar-nav navbar-left">
                    <li><a href="ClaseProf.aspx">Clase</a></li>
                    <li><a href="TesteProf.aspx">Teste</a></li>
                    <li><a href="PropuneriProf.aspx">Propuneri</a></li>
                </ul>
                <ul class="nav navbar-nav navbar-right">
                    <li>
                        <a href="Log In.aspx">
                            <span class="glyphicon glyphicon-log-out"></span>Log Out
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>
    <br />
    <br />
    <form runat="server">
        <div style="padding-top: 50px; padding-bottom: 50px;" class="row">
            <div class="col-md-1"></div>
            <div class="col-md-10 wb slide slideanim">
                <h2 class="text-center" runat="server" id="Numeleclasei">Te rugam selecteaza o clasa!</h2>
                <br />
                <div class="row">
                    <div class="col-md-2">
                        <label>Clasa</label>
                        <br />
                        <asp:DropDownList runat="server" ID="sel" CssClass="form-control"></asp:DropDownList>
                    </div>
                    <div class="col-md-10">
                        <label>Numele testului:</label><br />
                        <asp:TextBox runat="server" ID="nume" CssClass="form-control"></asp:TextBox>
                        <br />
                        <label>Alegeti testul</label><br />
                        <asp:DropDownList runat="server" ID="quiz" CssClass="form-control"></asp:DropDownList><br />
                        <asp:Button runat="server" ID="add" Text="Posteaza testul" CssClass="btn btn-success pull-right" OnClick="add_Click" /><br />
                    </div>
                </div>
            </div>
            <div class="col-md-1"></div>
        </div>
    </form>
</body>
</html>