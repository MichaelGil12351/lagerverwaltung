package com.ebootis.spring_boot.repositories;

import com.ebootis.spring_boot.models.ProcessPosition;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface IProcessPositionRepository extends JpaRepository<ProcessPosition,Integer> {
}
