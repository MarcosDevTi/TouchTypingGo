// Curso de digitação - Marcos de Souza 

//var xmlhttp;

var TipoPalvr = true;
var KeyHint = true;
var TipoTexto = true;

var Pos = 0;
var Index = 0;
var TextDoneArr = [];
var TextDone = '';
var TextCurrent = '';
var textoErrado = '';
var Text = [];


var TotalLength = 0;
var TotalPos = 0;
var TotalErros = 0;
var TempoMinFinal = 0;
var TempoSecFinal = 0;

var LastError = false;
var FirstTime = true;

var Progress = [];
var ProgressBad = [];

var Tcls = [];
var TclsUsadas = [];
var velocFinal = 0;


var Time = 0;

var LessonInitialized = null;


function OnKeyDown(o, e) {
    var numTecla = window.event ? e.keyCode : e.which;
    var arr = Tcls[numTecla];
    
    if (numTecla === 8 // back
        || numTecla === 9 // tab
        || numTecla === 16 // shift
        || numTecla === 17 // ctrl
        || numTecla === 18 // alt
        || numTecla === 27 // esc
        || numTecla === 33 // pg up
        || numTecla === 34 // pg down
        || numTecla === 35 // end
        || numTecla === 36 // home
        || numTecla === 37 // left
        || numTecla === 38 // up
        || numTecla === 39 // right
        || numTecla === 40 // down
        || numTecla === 45 // ins
        || numTecla === 46 // del
        || (numTecla === 65 && e.ctrlKey && !e.altKey) // ctrl + a
        || (numTecla === 86 && e.ctrlKey && !e.altKey) // ctrl + v
        || (numTecla === 88 && e.ctrlKey && !e.altKey) // ctrl + x
    ) {
        if (o.setSelectionRange) {
            o.focus();
        }
        else if (o.createTextRange) {
            e.returnValue = false;
        }

        var len = o.value.length;
        if (numTecla === 8 && TipoPalvr && len > 0 && o.value.charAt(len - 1) !== ' ') // back
        {
            return;
        }

        if (e.preventDefault) {
            e.preventDefault();
        }
    }
    
}
function OnKeyPress(o, e) {
   

    var numTecla = window.event ? e.keyCode : e.which;
    var keychar = String.fromCharCode(numTecla);

    if (Time === 0) {
        Time = new Date();
    }

    if (TipoPalvr) {
        var len = o.value.length;
        if (numTecla === 8) // backspace
        {
            if (len > 0 && o.value.charAt(len - 1) !== ' ') {
                o.value = o.value.substring(0, len - 1);

            }
        }
        else {
            if (numTecla === 32 || numTecla === 13) {
                var c = o.value.charCodeAt(len - 1);
                if (len > 0 && (c === 32 || c === 10)) {
                    keychar = '';
                }
                else {
                    ++Pos;
                    TotalPos += TextCurrent.length + 1;
                    HighlightText(numTecla === 13 ? '\r' : null);

                    if (Pos === 0) {
                        o.value = '';
                        keychar = '';
                    }
                }
            }
            o.value += keychar;
        }
    }
    else {
        ClearKeysUsed();

        if (!IsPosLength())
            return false;

        var keyval = Text[Index].charAt(Pos);
        var keycode = Text[Index].charCodeAt(Pos);

        if (keycode === numTecla) {
            o.value += keychar;
            ++Pos;
            ++TotalPos;
            HighlightText();
            if (TotalPos === 1) {
                //chronoStart();
            }
            if (Pos === 0) {
                o.value = '';
                keychar = '';
            }
        }
        else {
            var arr = Tcls[numTecla];

            if (arr) {
                for (var i in arr) {
                    ById('key_' + arr[i]).style.backgroundColor = '#f00';
                    TclsUsadas.push(arr[i]);
                }
            }

            LastError = true;
        }

        AddProgress(keyval, LastError);

        ShowNextKey();
    }

    o.scrollTop = o.scrollHeight - o.clientHeight;
    console.log(Pos);
    console.log(IsTextLength());
    console.log($("#identExerc").val());
    // end
    if (Pos === 0 && !IsTextLength()) {
        
        ShowConclusion();  
    }

    return false;
}

function GetXmlHttpObject() {
    if (window.XMLHttpRequest) {
        // code for IE7+, Firefox, Chrome, Opera, Safari
        return new XMLHttpRequest();
    }
    if (window.ActiveXObject) {
        // code for IE6, IE5
        return new ActiveXObject("Microsoft.XMLHTTP");
    }
    return null;
}

function ClearKeysUsed() {
    // clear keys
    var z = TclsUsadas.shift();
    while (z) {
        ById('key_' + z).style.backgroundColor = '#fff';
        z = TclsUsadas.shift();
    }
}

function Trim(str) {
    return str.replace(/^\s\s*/, '').replace(/\s\s*$/, '');
}

function ShowNextKey() {
    if (!IsPosLength())
        return;

    var numTecla = Text[Index].charCodeAt(Pos);
    var arr = Tcls[numTecla];

    if (!arr)
        return;

    var fingers = [];

    if ($(window).width() >= 10 && $(window).width() < 2160) {
        fingers = new Array(

            new Array(135, 596),
            new Array(176, 536),
            new Array(227, 508),
            new Array(304, 516),
            new Array(387, 629),
            new Array(1493, 629),
            new Array(1575, 517),
            new Array(1653, 508),
            new Array(1704, 538),
            new Array(1743, 597)
        );
    }


    var i;
    for (i = 0; i < arr.length; ++i) {
        var k = arr[i];
        var f;
        $("#e1").hide();
        $("#e2").hide();
        $("#e3").hide();
        $("#e4").hide();
        $("#e5").hide();
        $("#d1").hide();
        $("#d2").hide();
        $("#d3").hide();
        $("#d4").hide();
        $("#d5").hide();
        switch (parseInt(k)) {
            case 101: case 102: case 202: case 302: case 401: case 402: case 403:
                f = 0;
                $("#e1").hide();
                $("#e2").hide();
                $("#e3").hide();
                $("#e4").hide();
                $("#e5").show();
                console.log("101");
                break;
            case 103: case 203: case 303: case 404:
                f = 1;
                $("#e1").hide();
                $("#e2").hide();
                $("#e3").hide();
                $("#e4").show();
                $("#e5").hide();
                console.log("103");
                break;
            case 104: case 204: case 304: case 405:
                f = 2;
                $("#e1").hide();
                $("#e2").hide();
                $("#e3").show();
                $("#e4").hide();
                $("#e5").hide();
                console.log("104");
                break;
            case 105: case 106: case 205: case 206: case 305: case 306: case 406: case 407:
                f = 3;
                $("#e1").hide();
                $("#e2").show();
                $("#e3").hide();
                $("#e4").hide();
                $("#e5").hide();
                console.log("105");
                break;
            case 504: case 505:
                f = 5;
                $("#e1").hide();
                $("#e2").hide();
                $("#e3").hide();
                $("#e4").hide();
                $("#e5").hide();
                $("#d1").show();
                console.log("504");
                break;
            case 107: case 108: case 207: case 208: case 307: case 308: case 408: case 409:
                f = 6;
                $("#d1").hide();
                $("#d2").show();
                $("#d3").hide();
                $("#d4").hide();
                $("#d5").hide();
                console.log("107");
                break;
            case 109: case 209: case 309: case 410:
                f = 7;
                $("#d1").hide();
                $("#d2").hide();
                $("#d3").show();
                $("#d4").hide();
                $("#d5").hide();
                console.log("109");
                break;
            case 110: case 210: case 310: case 411:
                f = 8;
                $("#d1").hide();
                $("#d2").hide();
                $("#d3").hide();
                $("#d4").show();
                $("#d5").hide();
                console.log("110");
                break;
            default:
                f = 9;
                $("#d1").hide();
                $("#d2").hide();
                $("#d3").hide();
                $("#d4").hide();
                $("#d5").show();
                console.log("default");
        }

        if (KeyHint || LastError) {

            ById('key_' + k).style.backgroundColor = 'rgb(42, 202, 69)';
            TclsUsadas.push(k);


            ById('finger_' + i).style.left = fingers[f][0] + 'px';
            ById('finger_' + i).style.top = fingers[f][1] + 'px';
        }

        ById('finger_' + i).style.display = (KeyHint || LastError) ? 'block' : 'none';
    }

    for (var j = i; j < 5; ++j) {
        ById('finger_' + j).style.display = 'none';
    }

}

function IsTextLength() {
    return Index < Text.length;
}

function IsPosLength() {
    if (IsTextLength())
        return Pos < Text[Index].length;
    else
        return false;
}



function HighlightText(enter) {

    var out = '';

    if (TipoPalvr) {
        var arr = Text[Index].split(' ');
        var typed = ById('type').value;
        var txt = (TipoTexto ? '_txt' : '');

        if (Pos > 0) {

            var t = typed.split(/ |\n/)[Pos - 1];
            if (enter)
                t += enter;


            LastError = (TextCurrent !== t);
            TextDone += '<span class="done' + txt + (LastError ? '_bad' : '_ok') + '">'
                + escapeHtml(TextCurrent) + '</span> ';

            TextDoneArr[Index] += t;
            if (!enter)
                TextDoneArr[Index] += ' ';
        }

        if (Pos >= arr.length) {
            ++Index;
            Pos = 0;

            if (!IsTextLength())
                return;

            arr = Text[Index].split(' ');

            TextDone = '';
            TextDoneArr[Index] = '';
        }
        TextCurrent = arr.length > Pos ? arr[Pos] : '';

        out = TextDone
            + '<span class="current' + txt + '">' + escapeHtml(TextCurrent) + '</span>'
            + '<span class="next' + txt + '">';
        for (var i = Pos + 1; i < arr.length; ++i) {

            out += ' ' + arr[i];
        }
        out += '</span>';
    }
    else {
        if (!IsPosLength()) {
            ++Index;
            Pos = 0;
            TextDone = '';
            TextDoneArr[Index] = '';
        }
        else if (Pos > 0) {
            TextDone += '<span class="done_' + (LastError ? 'bad' : 'ok') + '">'
                + escapeHtml(TextCurrent) + '</span>';
        }

        if (!IsTextLength())
            return;

        TextCurrent = Text[Index].charAt(Pos);

        out = TextDone
            + '<span class="current">' + (TextCurrent) + '</span>'
            + '<span class="next">' + escapeHtml(Text[Index].substring(Pos + 1)) + '</span>';
    }

    // enter
    if (TipoTexto)
        out = out.replace(/\r/g, '<br />');
    else
        out = out.replace(/\r/g, '&crarr;<br />');
    ById('text').innerHTML = out;

    ShowMeter();

    LastError = false;
}

function ShowHint(delta) {
    if (delta > 0)
        ++Index;
    else if (delta < 0)
        --Index;

    if (!IsTextLength())
        Index = Text.length - 1;
    if (Index < 0)
        Index = 0;

    var out = IsTextLength() ? Text[Index] : '';
    ById('text').innerHTML = out;

    ById('hint_prev').style.display = (Index === 0 ? 'none' : 'block');
    ById('hint_next').style.display = (Index > Text.length - 2 ? 'none' : 'block');
    ById('hint_type').style.display = (Index < Text.length - 1 ? 'none' : 'block');

    return false;
}

var numLetras = [];
var letras = [];


function AddProgress(key, bad) {

    if (LessonInitialized === null) {
        chronoStart();
    }

    LessonInitialized = true;

    if (bad === true) {
        textoErrado += key;
    }

    if (!FirstTime) {
        FirstTime = !bad;
        return;
    }

    if (FirstTime === false) {
        var ErrTotais = getFrequency(textoErrado);
        console.log(ErrTotais);
    }

    var qty = Progress[key];
    if (qty === undefined)
        qty = 0;

    Progress[key] = ++qty;

    if (bad) {
        qty = ProgressBad[key];
        if (qty === undefined)
            qty = 0;
        ProgressBad[key] = ++qty;

        var found = jQuery.inArray(key, letras);
        if (found >= 0) {
            // Element was found, remove it.
            letras.splice(found, 0);
            numLetras[letras.indexOf(key)];
            var ind = letras.indexOf(key);
            numLetras[ind]++;
            console.log(numLetras);

        } else {
            // Element was not found, add it.
            console.log("novo");
            numLetras.push(1);
            letras.push(key);
            console.log(letras);
            console.log(numLetras);
        }

        //Gráficos

        var bar = new RGraph.Bar({
            id: 'cvs',
            data: numLetras,
            options: {
                labels: letras,
                colorsSequential: true,
                shadowColor: '#999',
                shadowOffsetx: 3,
                shadowOffsety: 3,
                shadowBlur: 5,
                strokestyle: 'rgba(0,0,0,0)',
                backgroundGridAutofitNumvlines: 5,
                noyaxis: true,
                textAccessible: true
            }
        }).draw();


        /**
        * Now the chart has been drawn use the coords to create some appropriate gradients
        */
        var colors = [];

        for (var i = 0; i < bar.coords.length; ++i) {
            // Because it's a horizontal gradient the Y coords don't matter
            var x1 = bar.coords[i][0];
            var y1 = 0;
            var x2 = bar.coords[i][0] + bar.coords[i][2];
            var y2 = 0;

            colors[i] = RGraph.linearGradient(bar, x1, y1, x2, y2, '#c00', 'red');
        }
        bar.set('colors', colors);
        RGraph.clear(bar.canvas);
        RGraph.redraw();
        // Fim dos gráficos
        TotalErros++;
    }

    FirstTime = !bad;
}
function medidorCircular() {

}

function ShowMeter() {
    var velocidade = ById('PreviewGaugeMeter_2');

    var left;
    var meter = ById('meter');


    var progresso = ById('progresso');
    var erros = ById('erros');
    var errLabel = ById('errosLabel');
    var errDesc = ById('errosDesc');
    var txErr = ById('textoErrado');

    if (meter === null)
        return;

    var percent = 0;
    if (TotalLength > 0) {
        percent = parseInt((TotalPos / TotalLength) * 100);
    }

    meter.style.backgroundPosition = left + 'px 0';
    progresso.style.width = (TotalPos / TotalLength) * 100 + '%';
    errLabel.contextmenu = "";

    var bad = 0;
    var texto = '';
    var strErro = '';

    for (var i in ProgressBad) {

        bad += ProgressBad[i];
        strErro += i.substring(i.length - 1);
    }


    if (Time > 0) {

        var diff = (new Date()).getTime() - Time.getTime();
        if (diff > 50) {
            var wpm = Math.ceil((TotalPos * 12) / (diff / 1000));
        }
        else {
            var wpm = 0
        }
        var diff_min = Math.floor(diff / 1000 / 60);
        var diff_sec = Math.ceil((diff - (diff_min * 1000 * 60)) / 1000);
    }
    else {
        var diff = 0;
        var wpm = 0;
        var diff_min = 0;
        var diff_sec = 0;
    }

    if (diff_min < 10) {
        diff_min = '0' + diff_min;
    }
    if (diff_sec < 10) {
        diff_sec = '0' + diff_sec;
    }
    var err = bad * 100 / TotalLength;
    erros.style.width = err + "0%";
    meter.innerHTML =
        wpm + ' ' + ById('lang_wpm').innerHTML;
    var concluidoTxtJs = $("#velocideDigi").text();
    if (percent < 20) {
        progresso.innerHTML = percent + '%';
    } else {
        progresso.innerHTML = percent + '%' + '  ' + concluidoTxtJs;
    }
    var velocideDigi = $("#velocideDigi").text();
    var palavrMinuto = $("#palavrMinuto").text();

    meter2.innerHTML = velocideDigi + ': ' + wpm + ' ' + palavrMinuto;
    $(".GaugeMeter").attr('data-percent', wpm);
    if (bad === 1) {
        lErr = ' Erro';
    } else {
        lErr = ' Erros';
    }
    velocFinal = wpm;
    errLabel.innerHTML = bad + lErr;

    var totErros = $("#totalDeErros").text();

    errConclusao.innerHTML = totErros + ': ' + bad;
    //$("#PreviewGaugeMeter_2").attr('data-percent', wpm);

    txErr.innerHTML = strErro;
}
function getFrequency(string) {
    var freq = {};
    for (var i = 0; i < string.length; i++) {
        var character = string.charAt(i);
        if (freq[character]) {
            freq[character]++;
        } else {
            freq[character] = 1;
        }
    }

    return freq;
};
function Init(type) {
    
    Text = Trim(ById('type_text').value).split('¶');
    Text.pop();

    if (type < 3) {
        ShowHint(0);
        return;
    }

    var a;
    var arr = ById('type_keys').value.split('¶');
    for (var i in arr) {
        if (arr[i]) {
            a = arr[i].split(':');
            Tcls[a[0]] = a[1].split(';');
        }
    }

    TipoPalvr = (type > 5);
    KeyHint = (type < 5);
    TipoTexto = (type > 7);

    var rep = TipoPalvr ? '\r ' : '\r';
    for (var i in Text) {
        Text[i] = Text[i].replace(/\\n/g, rep);
        if (!TipoPalvr)
            Text[i] += ' ';
    }

    TotalLength = Text.join(TipoPalvr ? ' ' : '').length;

    if (TipoPalvr) {
        TextDoneArr[0] = '';
    }
    else {
        ShowNextKey();
    }

    HighlightText();

    document.type_form.type.focus();
}

function ById(id) {
    return document.getElementById(id);
}

function escapeHtml(unsafe) {
    return unsafe
        .replace(/&/g, "&amp;")
        .replace(/</g, "&lt;")
        .replace(/>/g, "&gt;")
        .replace(/"/g, "&quot;")
        .replace(/'/g, "&#039;");
}

function addLoadEvent(f) {
    var old = window.onload;
    window.onload = function () {
        if (old) { old(); }
        f();
    };
}

addLoadEvent(function() {
    Init(3);
});

var ltrExc = [
    " ", "?", "-"
];
function existeExercicio(ltr) {
    if (jQuery.inArray(ltr, ltrExc) !== -1) {
        return true;
    } else {
        return false;
    }
}


function ShowConclusion() {
    var ltrCount = $("#ltrCount").text();
    var PpmIdeal = $("#ppmIdeal").text();
    var percErros = 100 * TotalErros / ltrCount;
    var velocidade = velocFinal;
    var qtdErrLtr = Math.max.apply(Math, numLetras);

    var ltrMErr = letras[numLetras.indexOf(qtdErrLtr)];
    var idExerc = $("#identExerc").val();
    console.log("Total de Letras " + ltrCount);
    console.log("Palavras por minuto ideal do exercício " + PpmIdeal);
    console.log("velocidade Alcançada " + velocidade);
    console.log("Percentual de erros do Exercício " + percErros);
    console.log("Puts");
    console.log(idExerc);
    console.log(velocFinal);
    

    
    window.location.replace("/free-online-touch-typing/exercice/" + $("#identExerc").val() + "/speed/" + velocFinal);

    var letraErro = " ";
    if (!existeExercicio(ltrMErr) && qtdErrLtr > 3) {
        letraErro = ltrMErr;
    } else {
        letraErro = "£";
    }

    

   //window.location.replace("/free-online-touch-typing/score/lesson/" + idExerc + "/speed/" + velocFinal + "/time/" + TempoMinFinal + TempoSecFinal + "/errors/" + TotalErros + "/error-key/" + letraErro);


    

    if (qtdErrLtr > 2 && !existeExercicio(ltrMErr)) {
        $("#txtLetra").text(ltrMErr);
        $("#LetraErro").val(ltrMErr);
        $('#alertPratMais').css('display', 'block');
    }

    else if (percErros > 2) {
        $('#alertErrTotais').css('display', 'block');
    }
    else {
        $('#alertSemErros').css('display', 'block');
    }
    //Estrelas
    //verifEstrelas(PpmIdeal, percErros, velocidade);

    $("#Tempo").val(TempoMinFinal + TempoSecFinal);
    $("#PPM").val(velocFinal);
    $("#TotalErros").val(TotalErros);
    //$("#btnResultadosView").click();


    //document.getElementById('btnResultadosView').click();
    chronoStop();
}



/*Gráfico*/

/*Fim do Gráfico*/
var startTime = 0;
var cronInic = 0;
var fimCronometro = 0;
var difCron = 0;
var timerID = 0;
function chrono() {

    var textoTempo = $("#tempoDecorr").text();
    var totalDeErros = $("#totalDeErros").text();

    fimCronometro = new Date();
    difCron = fimCronometro - cronInic;
    difCron = new Date(difCron);
    var sec = difCron.getSeconds();
    var min = difCron.getMinutes();
    if (min < 10) {
        min = "0" + min;
    }
    if (sec < 10) {
        sec = "0" + sec;
    }
    TempoMinFinal = min;
    TempoSecFinal = sec;
    document.getElementById("labelMedidor").innerHTML = min + ":" + sec;
    timerID = setTimeout("chrono()", 10);


    //document.getElementById("labelMedidor2").innerHTML = textoTempo + ": " + min + ":" + sec;
    //timerID = setTimeout("chrono()", 10)
}
function chronoStart() {
    document.chronoForm.startstop.value = "stop!";
    document.chronoForm.startstop.onclick = chronoStop;
    document.chronoForm.reset.onclick = chronoReset;
    cronInic = new Date();
    chrono();
}

function chronoContinue() {
    document.chronoForm.startstop.value = "stop!";
    document.chronoForm.startstop.onclick = chronoStop;
    document.chronoForm.reset.onclick = chronoReset;
    cronInic = new Date() - difCron;
    cronInic = new Date(cronInic);
    chrono();
}
function chronoReset() {
    document.getElementById("labelMedidor").innerHTML = "00:00";
    cronInic = new Date();
}
function chronoStopReset() {
    document.getElementById("labelMedidor").innerHTML = "00:00";
    document.chronoForm.startstop.onclick = chronoStart;
}
function chronoStop() {
    document.chronoForm.startstop.value = "start!";
    document.chronoForm.startstop.onclick = chronoContinue;
    document.chronoForm.reset.onclick = chronoStopReset;
    clearTimeout(timerID);
}


