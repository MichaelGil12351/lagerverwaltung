package com.ebootis.spring_boot.repositories;

import com.ebootis.spring_boot.models.User;
import org.springframework.data.jpa.repository.JpaRepository;

public interface IUserRepository extends JpaRepository<User,Integer> {
}
