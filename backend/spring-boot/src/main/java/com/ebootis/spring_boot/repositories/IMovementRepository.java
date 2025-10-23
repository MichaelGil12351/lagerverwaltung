package com.ebootis.spring_boot.repositories;

import com.ebootis.spring_boot.models.Movement;
import org.springframework.data.jpa.repository.JpaRepository;

public interface IMovementRepository extends JpaRepository<Movement,Integer> {
}
