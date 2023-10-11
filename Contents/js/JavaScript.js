function OpenLink(id) {
    window.open("Actions.aspx?ID=" + id,"MyPage", "width=600, height=400, left=400, top=75");
}

function CloseWindow() {
    window.close();
    window.opener.location.reload();
}

