function name(arr) {
  class Song {
    constructor(type, name, time) {
      this.type = type;
      this.name = name;
      this.time = time;
    }
  }
  let songs = [];
  let numberOfSongs = arr.shift();
  let typeSong = arr.pop();

  for (let index = 0; index < numberOfSongs; index++) {
    let [type, name, time] = input[i].split["_"];
    let song = new Song(type, name, time);
    songs.push(song);
  }

  if (typeSong === "all") {
    songs.forEach((i) => console.log(i.name));
  } else {
    let filtered = songs.filter((i) => i.type === typeSong);
    filtered.forEach((i) => console.log(i.name));
  }
}
