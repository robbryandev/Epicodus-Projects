export default async function request(url: string): Promise<any> {
  return new Promise((resolve, reject) => {
    const req = new XMLHttpRequest();
    req.addEventListener("loadend", function() {
      if (req.status === 200) {
        const data = JSON.parse(req.responseText);
        resolve(data);
      } else {
        reject("Api error");
      }
    });
    req.open("GET", url, true);
    req.send();
  });
}