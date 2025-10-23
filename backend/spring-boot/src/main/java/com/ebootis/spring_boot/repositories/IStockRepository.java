package com.ebootis.spring_boot.repositories;

import com.ebootis.spring_boot.models.Stock;
import org.springframework.data.jpa.repository.JpaRepository;

public interface IStockRepository extends JpaRepository<Stock,Integer> {
}
