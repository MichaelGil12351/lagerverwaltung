package com.ebootis.spring_boot.models;

import jakarta.persistence.*;
import lombok.Data;
import lombok.NoArgsConstructor;

import java.util.List;

@Data
@NoArgsConstructor
@Entity
public class Movement {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Integer id;

    private Integer quantity;

//    @OneToMany(mappedBy = "movement", cascade = CascadeType.ALL)
//    private List<ProcessPosition> processes;

    @ManyToOne
    @JoinColumn(name = "user_id")
    private User user;
}

