function sub()
{
    var score=0;
    var a=document.getElementById("t1");
    var a1=document.getElementById("t2");
    var a2=document.getElementById("t3");
    if(a.checked==true)
        {
            score++;
        }
        if(a1.checked==true)
            {
                score++;
            }
            if(a2.checked==true)
                {
                    score++;
                }
               alert(document.getElementById("u").value+"got"+score+"correct");
}