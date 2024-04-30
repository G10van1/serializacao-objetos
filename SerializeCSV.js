const fs = require('fs');
const { parse } = require('json2csv');

// Dados a serem serializados em CSV
const data = [
    { nome: "Ana", idade: 25, cidade: "São Paulo" },
    { nome: "João", idade: 30, cidade: "Rio de Janeiro" }
];

// Converter dados para CSV
const csv = parse(data);

// Gravar dados em arquivo CSV
fs.writeFileSync('pessoas.csv', csv);

console.log("Dados serializados em CSV no arquivo pessoas.csv");
