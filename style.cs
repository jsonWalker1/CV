*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: Arial, Helvetica, sans-serif;
    list-style: none;
}

body{
    background-color: #A9E7F0;
}

.main {
    min-height: 100vh;
    margin: 0 10%;
    display: grid;
    grid-template-columns: repeat(7, 1fr);
}
.profile img{
    border-radius: 20%;
    border: solid 3px black ;
    width: 60%;
}
.profile{
    background-color: #5A64ED;
    text-align: center;
}
.name{
    color: #fff;
    padding-top: 0.3rem;
}
.career {
    color: #fff;
    text-transform: uppercase;
    padding: 1rem;
}
.left {
    grid-column: span 2;
    background-color: #5A64ED;    
}
.right {
    padding: 1rem 3rem;
    grid-column: span 5;
    background-color: #fff;
}
.contact-list li {
    text-align: center;
    height: 50px;     
}

.contact-list a {
    text-align: center;
    color: #fff;
    text-decoration: none;
    
}

.contact-list i {
    margin-right: 10px;       
    font-size: 1rem;          
}
.skills{
    text-align: center;
}
.skills h2 {
    color: #fff;
    text-align: center;
    text-transform: uppercase;
}
.skills I {
    color: #fff;
    padding: 2rem;
    display: block;
    width: 30%;
    margin: auto;
}
.about-me{
    font-size: 3rem;
    text-transform: uppercase;
    position: relative;
}
.about-me::after{
    content: '';
    position: absolute;
    width: 50%;
    height: .3rem;
    background-color: #5A64ED;
    right: 0;
    transform: translateY(-50%);
}
.about-me-text {
    line-height: 1.5rem;
}