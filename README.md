# Free-Unity-Touchpad
Free-Unity-Touchpad

پکیج ساده جوی استوک و باتن برای بازی های موبایل به سبک اینپوت سیستم قدیمی یونیتی

در این پکیج برای باتن ها سه متد 

public​ ​static​ ​bool​ ​GetKeyDown()<br>

//----------

public​ ​static​ ​bool​ ​GetKeyUp​(​)<br>

//----------

public​ ​static​ ​bool​ ​GetKeyPress()<br>

//----------

وجود دارد که شامل دو اورلود استرینگ و کی کد هستن 

بعنوان مثال

bool E0 = ZInput​.​GetKeyDown​(​"​button1​"​);

bool E1 = ZInput​.​GetKeyDown​(​KeyCode​.​Space);

برای جوی استوک متدی به نام

public​ ​static​ ​float​ ​GetAxis​(​)

داریم که بعنوان ورودی یک استرینگ میگره بعنوان مثال

float​ ​x​ ​=​ ​ZInput​.​GetAxis​(​"​X​"​);<br>

برای گرفتن دایرکش جوی استوک میتونید از متد های استفاده کنید

public static Quaternion Get_2D_Direction(string Direction)

//---------

public static Quaternion Get_3D_Direction(string Direction)

//---------

بعنوان مثال 

transform.rotation = ZInput.Get_3D_Direction("3D_Dir");

transform.rotation = ZInput.Get_2D_Direction("2D_Dir");

پریفاب های باتن و جوی استوک در پوشه 

prefab 

هست و یک مثال ساده در پوشه  

Example 

وجود دارد
