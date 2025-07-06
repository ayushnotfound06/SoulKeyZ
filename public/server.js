const express = require('express');
const fs = require('fs');
const path = require('path');
const app = express();
const PORT = 3000;

app.use(express.json());
app.use(express.static('public'));

const filePath = path.join(__dirname, 'products.json');

// GET all products
app.get('/api/products', (req, res) => {
  fs.readFile(filePath, 'utf8', (err, data) => {
    if (err) return res.status(500).json({ error: 'Read failed' });
    res.json(JSON.parse(data));
  });
});

// POST add product
app.post('/api/products', (req, res) => {
  const newProduct = req.body;

  fs.readFile(filePath, 'utf8', (err, data) => {
    if (err) return res.status(500).json({ error: 'Read failed' });

    let products = JSON.parse(data);
    newProduct.id = Date.now(); // generate a simple unique id
    products.push(newProduct);

    fs.writeFile(filePath, JSON.stringify(products, null, 2), err => {
      if (err) return res.status(500).json({ error: 'Write failed' });
      res.json({ message: 'Added', product: newProduct });
    });
  });
});

// DELETE product by id
app.delete('/api/products/:id', (req, res) => {
  const productId = parseInt(req.params.id);

  fs.readFile(filePath, 'utf8', (err, data) => {
    if (err) return res.status(500).json({ error: 'Read failed' });

    let products = JSON.parse(data);
    products = products.filter(p => p.id !== productId);

    fs.writeFile(filePath, JSON.stringify(products, null, 2), err => {
      if (err) return res.status(500).json({ error: 'Write failed' });
      res.json({ message: 'Deleted' });
    });
  });
});

app.listen(PORT, () => console.log(`Server running at http://localhost:${PORT}`));
