package com.informaticonfig.spring_boot.dto;

import com.informaticonfig.spring_boot.model.Autor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
public class AutorDTO {
    private Integer id;
    private String name, surname, phone;

    public AutorDTO(Autor p_autor) {
        this.id = p_autor.getId();
        this.name = p_autor.getName();
        this.surname = p_autor.getSurname();
        this.phone = p_autor.getPhone();
    }
}
