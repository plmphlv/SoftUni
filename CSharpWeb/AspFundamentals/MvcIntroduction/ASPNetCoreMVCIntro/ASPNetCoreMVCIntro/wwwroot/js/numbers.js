function SetLimit() {
    let num = document.getElementById("limitInput").value || 3;

    window.location = "https://localhost:7016/Number/PrintNumbers?num=" + num;
}

function BackToInput() {
    window.location = "https://localhost:7016/Number";
}