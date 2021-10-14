﻿// config map
let config = {
    minZoom: 2,
    maxZomm: 18,
};
// magnification with which the map will start
const zoom = 6;
// co-ordinates
const lat = 26.8206;
const lng = 30.8025;

// calling map
var map = L.map("map", config).setView([lat, lng], zoom);

// Used to load and display tile layers on the map
// Most tile servers require attribution, which you can set under `Layer`
L.tileLayer("https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png", {
    attribution:
        '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors',
}).addTo(map);

function onEachFeature(feature, layer) {
    layer.bindPopup(feature.properties.nazwa);
}

// adding geojson by fetch
// of course you can use jquery, axios etc.
fetch("/GeoJsonSimple/geojsonFile")
    .then(function (response) {
        return response.json();
    })
    .then(function (data) {
        // use geoJSON
        L.geoJSON(data, {
            onEachFeature: onEachFeature,
        }).addTo(map);
    });

