# multiplayer-tutorial-unity

משחק זה הוא מולטי פלייר בתלת מימד אשר ביצענו בו 2 שינויים:

## הוספת מגן
הוספנו מגן לזירת המשחק שאותו יוכל השחקן לקחת ולהגן על עצמו מפני השחקן היריב,
 כאשר יקח את המגן הוא יהיה מוגן מקרני הלייזר ולא ירדו לו חיים במשחק.
 למגן הוספנו Photon Trasnform View ו Photon View.
[shield](https://github.com/S-DevelopeGame/FirstMultiPlayerGame/blob/master/Assets/scripts/Player/PlayerManager.cs).
[TimedSpawnerRandom](https://github.com/S-DevelopeGame/FirstMultiPlayerGame/blob/master/Assets/scripts/Player/TimedSpawnerRandom.cs).
[CollisionShield](https://github.com/S-DevelopeGame/FirstMultiPlayerGame/blob/master/Assets/scripts/CollisionShield.cs).

## הוספת אנימציה
הוספנו אנימציה לשחקן בדמות של רובוט שיורה חצי לייזר.
 הוספנו photon animator view, את תכונות האנימציה ב playerManager. 
 

## הוראות המשחק:
* לחצו אעל החצים ימינה ושמאלה במקלדת על מנת להזיז את השחקן
* השתמשו בעכבר כדי לראות את הזירה למעלה ולמטה ימינה ושמאלה ממבטו של השחקן
* לחצו לחיצה ארוכה על העכבר על מנת לירות חצי לייזר

## רוצים לשחק?
לחצו : https://snir1551.itch.io/firstmultiplayergame
