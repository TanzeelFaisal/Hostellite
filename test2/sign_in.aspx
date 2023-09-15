<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sign_in.aspx.cs" Inherits="test2.sign" %>

<!DOCTYPE html>
<html lang="zxx">

<!-- Head -->

<head>

    <title>Hostellite | Sign in</title>

    <!-- Meta-Tags -->
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">

    <!-- style CSS -->
    <link rel="stylesheet" href="css/style.css" type="text/css" media="all">
    <!-- google fonts -->
    <link href="https://fonts.googleapis.com/css2?family=Noto+Sans+JP:wght@400;500;700&display=swap" rel="stylesheet">
</head>
<!-- //Head -->

<!-- Body -->

<body>
    <section class="main">
        <div class="logo text-center">
            <h1> <a href="index.html"> Sign In </a></h1>
        </div>
        <div class="content-w3ls text-center">
            <img src="images/admin.png" alt="" class="img-responsive">
            <form action="#" method="post">
                <div class="wthree-field">
                    <input name="text1" id="text1" type="text" value="" placeholder="Username" required>
                </div>
                <div class="wthree-field">
                    <input name="password" id="myInput" type="Password" placeholder="Password">
                </div>
                <div class="wthree-field">
                    <button type="submit" class="btn">Sign In</button>
                </div>
                <div class="login-bottom">
                    <a href="#url" class="">Create An Account</a>
                </div>
            </form>
        </div>
    </section>

</body>
<!-- //Body -->

</html>