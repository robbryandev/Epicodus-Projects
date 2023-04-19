function count(to, by) {
  if (typeof to !== "number" || typeof by !== "number") {
    return [];
  }
  let res = [];
  for (let cool = by; cool <= to; cool += by) {
    res.push(cool);
  }
  return res;
}

console.log(count(20, "20"));