# Free-Unity-Touchpad
Free-Unity-Touchpad

<br>

پکیج ساده جوی استوک و باتن برای بازی های موبایل به سبک اینپوت سیستم قدیمی یونیتی

<br>

در این پکیج برای باتن ها سه متد 

<br>

public​ ​static​ ​bool​ ​GetKeyDown()<br>

//----------<br>

public​ ​static​ ​bool​ ​GetKeyUp​(​)<br>

//----------<br>

public​ ​static​ ​bool​ ​GetKeyPress()<br>

//----------<br>

وجود دارد که شامل دو اورلود استرینگ و کی کد هستن 

<br>

بعنوان مثال

<br>

bool E0 = ZInput​.​GetKeyDown​(​"​button1​"​);<br>
bool E1 = ZInput​.​GetKeyDown​(​KeyCode​.​Space);<br>

برای جوی استوک متدی به نام<br>
public​ ​static​ ​float​ ​GetAxis​(​)<br>
داریم که بعنوان ورودی یک استرینگ میگره بعنوان مثال<br>

<br>

float​ ​x​ ​=​ ​ZInput​.​GetAxis​(​"​X​"​);<br>


<br>
پریفاب های باتن و جوی استوک در پوشه prefab هست و یک مثال ساده در پوشه  Example وجود دارد
