# Gartomatic
Gartomatic is an automated Bot and Bot-Manager for the browser game [Gartic.io](https://gartic.io/) written in C#.

## How it works
Gartomatic utilizes a headless version of the [Chrome Embedded Framework](https://github.com/cefsharp/CefSharp) combined with a custom JavaScript-Bridge *(GarticHook.js)* in order to communicate with the game and execute various tasks fully automated.

This process is optimized for hosting a large amount of Bots at the same time  without slowing down or crashing (See **Performance**). You can easily perform many actions through a simple and intuitive GUI or enable the Auto-Bot and let all clients play the game automatically.

## Performance
Gartomatic is quite performance friendly and uses about 850MB of RAM while running 10 Bots. On a Ryzen 7 3700X, the CPU usage stays below 1% most of the time.

## Usage
Compile the project yourself or download a pre-compiled version from the [Releases](https://google.de) and run it. Make sure that GarticHook.js as well as all CEF-Requisites are available in your target directory.
Witohut them, Gartomatic will not be able to run.

## Features
* Report Drawing
* Kick Player
* Send Chat Message
* Send Answer
* Change Username [~]
* Change Avatar [~]
* Get Answer [*]
* Show Hint [*]
* Skip Drawing [*]
* **Automated Tools:** Auto Report, Auto Skip, Auto Rejoin, Auto Answer, Chatspam
* **Auto-Bot:** Automated Quickplay, Custom Room List

[~] = Currently limited or hard-coded
[*] = Only works when a bot is currently drawing

## Contribution
Feel free to add to this project via Pull-Requests or create a new Issue if something isn't working as intended.

## Thanks
Thanks to the team behind [Gartic.io](https://gartic.io/)! Without them, this project wouldn't have been possible. Also thanks for [Chrome Embedded Framework](https://github.com/cefsharp/CefSharp) that powers all of this.
