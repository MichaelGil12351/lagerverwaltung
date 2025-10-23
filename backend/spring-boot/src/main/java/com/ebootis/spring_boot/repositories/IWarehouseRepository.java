package com.ebootis.spring_boot.repositories;

import com.ebootis.spring_boot.models.Warehouse;
import org.springframework.data.jpa.repository.JpaRepository;

public interface IWarehouseRepository extends JpaRepository<Warehouse,Integer> {

}
