## Selenium and WordPress
Building a UI automated testing framework with Selenium 3.4 for a WordPress site

### Overview
This project sets to create an automated testing framework using Selenium with C#. The main goal is to have the tests only communicating
with Selenium while Selenium manipulates the Browser accordingly. This three (app: tests: selenium) layer architecture is configurable and modularized.

### Requirements
1. Visual Studio Community 2015 (https://www.visualstudio.com/)
2. Internet Connection
3. C# and Selenium knowledge

### Set Up
Download the Selenium FirefoxDriver from 
https://github.com/mozilla/geckodriver/releases. Add its location to the Windows OS system environment path,
 e.g. ``C:\apps\geckodriver.exe`` (no need to include the geckodriver.exe in the path). From within Visual Studio, 
 select a test and ``Run Tests``.
 
### Licence
````
MIT License

Copyright (c) 2017 Mr Modise

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

````

