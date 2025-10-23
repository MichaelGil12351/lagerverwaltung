package com.ebootis.spring_boot.models;

import jakarta.persistence.*;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.time.OffsetDateTime;
import java.util.List;

@Data
@NoArgsConstructor
@Entity
public class Article {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    private String name;
    private String description;
    private String form;
    private Integer price;

    private OffsetDateTime createdAt; // ← NUEVO

    @ManyToOne(fetch = FetchType.LAZY)
    @JoinColumn(name = "storage_location_id")
    private Warehouse storageLocation; // ← NUEVO

    @OneToMany(mappedBy = "article")
    private List<Stock> stocks;
    @OneToMany(mappedBy = "article", fetch = FetchType.LAZY)
    private List<ProcessPosition> processPositions;

}
