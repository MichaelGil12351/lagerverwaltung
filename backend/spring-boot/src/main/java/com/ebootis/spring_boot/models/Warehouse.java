package com.ebootis.spring_boot.models;

import jakarta.persistence.*;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.List;

@Data
@NoArgsConstructor
@Entity
public class Warehouse {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    private String name;
    private Integer maxCapacity;

    @OneToMany(mappedBy = "warehouse")
    private List<Stock> stocks;

    @OneToMany(mappedBy = "storageLocation", cascade = CascadeType.ALL, orphanRemoval = true)
    private List<Article> articles;

    @OneToMany(mappedBy = "sourceLocation")
    private List<ProcessPosition> asSourcePositions;

    @OneToMany(mappedBy = "targetLocation")
    private List<ProcessPosition> asTargetPositions;
}
