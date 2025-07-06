document.addEventListener("DOMContentLoaded", () => {
  const API_URL = "https://your-backend.onrender.com";

  fetch(`${API_URL}/api/products`)
  .then(res => res.json())
  .then(products => {
      const container = document.getElementById('productContainer');
      products.forEach(product => {
          const card = document.createElement('div');
          card.className = 'product-card';
          card.innerHTML = `
              <img src="${product.image}" alt="${product.name}">
              <div class="product-info">
                  <h4>${product.name}</h4>
                  <p>₹${product.price}</p>
              </div>
          `;
          container.appendChild(card);
      });
  });
});

  
