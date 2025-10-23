package com.ebootis.spring_boot.dtos;

import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
public class MovementDTO {
    private Integer id;
    private Integer quantity;
    private Integer userId;
    private String username;
}
