package service;

import model.Product;

import java.util.List;

public interface IProductService {
    List<Product> findALl();

    void create(Product product);

    void update(int id,Product product);

    void delete(int id);

    List<Product> findByName(String name);

    Product findById(int id);
}
