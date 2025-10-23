package com.ebootis.spring_boot.models;

import jakarta.persistence.*;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.time.OffsetDateTime;
import java.util.List;

@Data
@NoArgsConstructor
@Entity
public class ProcessPosition {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    private Integer quantity;

    @ManyToOne
    @JoinColumn(name = "article_id")
    private Article article;

    @ManyToOne
    @JoinColumn(name = "source_location_id")
    private Warehouse sourceLocation;

    @ManyToOne
    @JoinColumn(name = "target_location_id")
    private Warehouse targetLocation;

//    @ManyToOne
//    @JoinColumn(name = "process_lager_id")
//    private ProcessPosition processLager;



    private OffsetDateTime timestamp;
}
