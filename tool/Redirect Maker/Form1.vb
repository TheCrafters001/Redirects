﻿Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RichTextBox1.Text = "<!DOCTYPE html>
<html>
<head>
    <meta http-equiv=""Refresh"" content=""3;URL=""" & TextBox1.Text & """>
    <meta charset=""UTF-8"">
    <title>Redirecting...</title>
    <meta name=""description"" content=""Redirecting Service"" >
 
    <!-- Mobile Specific Meta -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!--[if IE]><meta http-equiv='X-UA-Compatible' content='IE=edge,chrome=1'><![endif]-->
 
    <link href='http://fonts.googleapis.com/css?family=Noto+Sans:400,700' rel='stylesheet' type='text/css'>
 
    <style>
 
        body{
            font-family: 'Noto Sans', Arial, serif;
            font-weight: 400;
            -webkit-font-smoothing:antialiased;
            -moz-osx-font-smoothing:grayscale;
            line-height: 1.618em;
            background: #464646 url('/Branding.png') center center no-repeat fixed;
            background-size: cover;
        }
        h2{
            font-family: 'Noto Sans', Arial, serif;
            font-weight: 700;
            font-size:40px;
            line-height: 1.618em;
        }
        section{
            max-width:800px;
            margin:8% auto 1em auto;
            background-color:#222;
            opacity: 0.8;
            filter: alpha(opacity=80); /* For IE8 and earlier */
            color:#fff;
            padding:1em 5%;
        }
 
        a{
            color: #00CC66;
        }
        a:focus{
            outline:none;
            outline-offset:inherit;
        }
        @media (max-device-width: 1027px) {
 
            body{
                text-align:center;
                font-size:larger;
            }
            section{
                max-width: 90%;
            }
 
        }
 
        @media (max-device-width: 640px) {
            section{
                max-width: 97%;
            }
 
        }
 
 
    </style>
</head>
<body>
 
<section>
    <h2>Redirecting to desired website...</h2>
 
    <h3>I am redirecting you to <a href=""" & TextBox1.Text & """>" & TextBox1.Text & "</a></h3>
    <h3>...You will be transferred to the new site in a moment...</h3>
 
    <p>If you have waited more than a few seconds and you are still seeing this message, please click on the link above! Thank you.</p>
</section>
 
</body>
</html>"
    End Sub
End Class
