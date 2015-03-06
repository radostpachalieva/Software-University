function ChangeImages(imageName) {
    if (imageName == "mustang") {
        document.getElementById("Image").src = "http://www.carwallpapers.ru/wp/ford-usa/mustang/2013-boss-302/Ford-Mustang-Boss-302-2013-1680x1050-005.jpg";
    }
    else if (imageName == "bmw") {
        document.getElementById("Image").src = "http://www.bmw.com/_common/shared/newvehicles/mseries/m5sedan/2013/showroom/safety_comfort/background.jpg";
    }
    else if (imageName == "porsche") {
        document.getElementById("Image").src = "http://www.carsession.com/news/photos/Porsche/Porsche-Panamera-4S-by-Schmidt-Revolution.jpg";
    }
    else if (imageName == "audi") {
        document.getElementById("Image").src = "http://news.finecarsexotics.com/wp-content/uploads/2012/05/audi-rs5-3.jpg";
    }
    else {
        document.getElementById("Image").src = "http://www.gtspirit.com/wp-content/gallery/gad-motors-c63/bs9.jpg";
    }
}