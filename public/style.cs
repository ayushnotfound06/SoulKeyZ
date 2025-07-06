*{
    margin: 0;
    font-family: VT323;
    border: border-box;
    
}

body {
    background-color: #0C4160;
}

/* BODY1 */

.navbar{
    height: 60px;
    background-color: #071330;
    color: #C3CEDA;
    display: flex;
    align-items: center;
    justify-content: space-evenly;
}
.nav-menu{
    font-size: 30px;
    color: #738FA7;
}

.nav-logo{
    height: 50px;
    width: 200px;
    width: 80%;
}
.logo{
    background-image: url("/Assets/withbg_logo.jpg");
    background-size: cover;
    height: 50px;
    width: 200px;
}
.nav-search{
    font-size: 30px;
    color: #738FA7;
}
.nav-cart{
    font-size: 30px;
    color: #738FA7;
}
.nav-user{
    font-size: 30px;
    color: #738FA7;
}

/* BODY2 */

.hero-banner{
    /* border: 2px solid red; */
    display: flex;
    justify-content: center;
    margin-top: 50px;
    height: 450px
}

.banner{
    background-image: url("/Assets/Banner1.jpg");
    height: 100%;
    width: 900px;
    background-size: cover;
    background-position: center;
    border-radius: 16px;
 }

/* BODY3 */

.banner-bar-container{
    /* border: 2px solid red; */
    display: flex;
    justify-content: center;
    margin-top: 50px;
    height: 150px
}

.banner-bar{
    background-image: url("/Assets/Banner-Bar.jpg");
    height: 100%;
    width: 900px;
    background-size: cover;
    background-position: center;
    border-radius: 16px;
}

.product-container {
    display: flex;
    flex-wrap: wrap;
    justify-content: center;
    gap: 20px;
    margin-top: 50px;
}

.product-card {
    background-color: #738FA7;
    width: 200px;
    border-radius: 10px;
    overflow: hidden;
    box-shadow: 0 0 10px rgba(0,0,0,0.2);
    font-family: Arial, sans-serif;
}

.product-card img {
    width: 100%;
    height: 180px;
    object-fit: cover;
}

.product-info {
    padding: 10px;
    text-align: center;
}

.product-info h4 {
    margin-bottom: 10px;
    font-size: 18px;
    color: #071330;
}

.product-info p {
    color: #0C4160;
    font-weight: bold;
}
