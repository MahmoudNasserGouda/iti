function getCookie(cookieName) 
{
        var cookieValue = "";
        if (document.cookie.length > 0) 
        {
                var cookieStart = document.cookie.indexOf(cookieName+ "=");
                if (cookieStart != -1) 
                {
                        var cookieEnd = document.cookie.indexOf(";",cookieStart + 1);
                        if (cookieEnd == -1)
                        {
                                cookieEnd = document.cookie.length; 
                        }
                        var cookieValue = unescape(document.cookie.substring(cookieStart+(cookieName.length)+1,cookieEnd));
                }
        }
        return cookieValue;
}


function setCookie(cookieName,cookieValue,expiryDate) 
{
        document.cookie = cookieName + "=" + escape(cookieValue) + ";expires=" + expiryDate.toGMTString();
}


function deleteCookie(cookieName) 
{
        var newDate = new Date();
        newDate.setTime(newDate.getTime() - 86400000);
        document.cookie = cookieName + "=deleted;expires=" +newDate.toGMTString();
}