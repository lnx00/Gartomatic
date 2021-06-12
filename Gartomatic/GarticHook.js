// Inject JQuery
let jqScript = document.createElement('script');
jqScript.src = 'https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.min.js';
jqScript.type = 'text/javascript';
document.getElementsByTagName('head')[0].appendChild(jqScript);

// GarticHook Module
let GarticHook = (() => {

    let Init = function () {
        setInterval(() => {
            $("#popUp > div.content > div.buttons > button").click(); // Anti-AFK
            $('#notification > div > div.containerWords > div:nth-child(1) > button').click(); // Auto pick drawing
            window.focus();
        }, 5000);

        Join();
    }

    let Join = function (pName, pAvatar = 8) {
        if (pName) {
            SetInputValue(document.querySelector("div.nick > label > input[type=text]"), pName);
        } else {
            let rndInt = Math.floor(Math.random() * (999 - 100 + 1) + 100);
            SetInputValue(document.querySelector("div.nick > label > input[type=text]"), "Human #" + rndInt);
        }

        if (pAvatar > 0) {
            $(".selectAvatar").click();
            $("div.avatars > div > div.scrollElements > ul > li:nth-child(" + pAvatar + ")").click();
            $("#popUp > div.content > div.buttons > button").click();
        }

        $("#screens > div > div.content.join > div.actions > button").click();
    }

    let ReJoin = function () {
        Leave(); // Potential disconnect
        $("#screens > div > div.content.join > div.actions > button").click();
    }

    let Leave = function () {
        $("#exit").click(); // Click exit button
        $("#popUp > div.content > div.buttons > button.btYellowBig.smallButton.ic-yes").click(); // Confirm
    }

    let Report = function () {
        $("#canvas > button").click(); // Click report button
        $("#popUp > div.content > div.buttons > button.btYellowBig.smallButton.ic-yes").click(); // Confirm
    }

    let Kick = function (pName) {
        $("span:contains('" + pName + "')").parent().parent().click(); // Open player profile
        $("#popUp > div.content.profile > div.buttons > button.btYellowBig.ic-votekick").click(); // Click votekick button
        $("#popUp > div.content > div.buttons > button.btYellowBig.smallButton.ic-yes").click(); // Click potential confirmation
        $("#popUp > div.content > div.buttons > button").click(); // Click potential alert
    }

    let Hint = function () {
        $("#hint > div > button:nth-child(1)").click();
    }

    let Skip = function () {
        $("#hint > div > button:nth-child(3)").click();
        $("#popUp > div.content > div.buttons > button.btYellowBig.smallButton.ic-yes").click();
    }

    let SendChat = function (pMessage) {
        SetInputValue(document.querySelector("input[name=chat]"), pMessage);
        document.querySelector("#chat > form").dispatchEvent(new Event("submit"));
    }

    let SendAnswer = function (pAnswer) {
        SetInputValue(document.querySelector("input[name=answer]"), pAnswer);
        document.querySelector("#answer > form").dispatchEvent(new Event("submit"));
    }

    let GetAnswer = function () {
        return $("#hint > div > div").text();
    }

    let GetStatus = function () {
        if ($(".word").length > 0) {
            return "Drawing";
        }

        if ($("#drawing").length > 0) {
            return "In-Game";
        }

        if ($("#screens > div > div.content.home > div.anonymus > div.actions > button.btBlueBig.ic-rooms").length > 0) {
            return "Home";
        }

        if ($("#screens > div > div.content.home > div.anonymus > div.actions > button.btBlueBig.ic-rooms").length > 0) {
            return "Joining";
        }

        return "Unknown";
    }

    let GetName = function () {
        let igName = $("div.user.you > div.infosPlayer > span.nick").text();
        if (igName) {
            return igName;
        } else {
            return $("#screens > div > div.content.join > div.infos > div.infosUsers > div.user > div.nick > label > input[type=text]").val();
        }
    }

    let SetInputValue = function (pInput, pText) {
        let inputSetter = Object.getOwnPropertyDescriptor(window.HTMLInputElement.prototype, "value").set;
        inputSetter.call(pInput, pText);

        pInput.dispatchEvent(new Event("input", { bubbles: true}));
    }

    return {
        Init: Init,
        Join: Join,
        ReJoin: ReJoin,
        Leave: Leave,
        Report: Report,
        Kick: Kick,
        Hint: Hint,
        Skip: Skip,
        SendChat: SendChat,
        SendAnswer: SendAnswer,
        GetAnswer: GetAnswer,
        GetStatus: GetStatus,
        GetName: GetName
    }

})();

// Wait for JQuery and Initialize GarticHook
function InitHook() {
    if (window.jQuery) {
        $(document).ready(() => {
            GarticHook.Init();
        });
    } else {
        setTimeout(() => {
            InitHook();
        }, 50);
    }
}
InitHook();