package repository.impl;

import model.Product;
import repository.IProductRepository;

import java.util.ArrayList;

import java.util.List;


public class ProductRepositoryImpl implements IProductRepository {
    private static final List<Product> productList = new ArrayList<>();

    static {
        productList.add(new Product(1, "Nokia 1", 10000, "xịn", "Nokia"));
        productList.add(new Product(2, "Iphone 8", 50000, "vip", "Iphone"));
        productList.add(new Product(3, "Iphone X", 70000, "pro", "Iphone"));
        productList.add(new Product(4, "Iphone XIII pro max", 10000, "vipPro", "Iphone"));
    }

    @Override
    public List<Product> findALl() {
        return productList;
    }

    @Override
    public void create(Product product) {
        productList.add(product);
    }

    @Override
    public void update(int id,Product product) {
        int index=0;
        for (int i = 0; i < productList.size() ; i++) {
            if(id == productList.get(i).getId()){
                index = i;
                break;
            }
        }
        productList.set(index, product);
    }

    @Override
    public void delete(int id) {
        int index=0;
        for (int i = 0; i < productList.size() ; i++) {
            if(id == productList.get(i).getId()){
                index = i;
                break;
            }
        }
        productList.remove(index);
    }

    @Override
    public List<Product> findByName(String name) {
        List<Product> searchResults = new ArrayList<>();
        for (Product p : productList) {
            if (p.getName().toLowerCase().contains(name.toLowerCase())) {
                searchResults.add(p);
            }
        }
        return searchResults;
    }

    @Override
    public Product findById(int id) {
        Product product = null;
        for (Product p : productList) {
            if (p.getId()==(id)) {
                product = p;
                break;
            }
        }
        return product;
    }
}
