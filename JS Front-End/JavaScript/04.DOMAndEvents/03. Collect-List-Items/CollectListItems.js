function extractText() {
  let itemNodes = Array.from(document.querySelectorAll("li"));
  let textArea = itemNodes.map((item)=>item.textContent).join("\n");
  document.querySelector("textarea").value=textArea;
}