package com.ebootis.spring_boot.services.generic;

import java.util.List;
import java.util.Optional;

public interface ICombinedGenericService<T, D, ID> {
    // CRUD entität
    T create(T entity);
    T update(T entity);
    Optional<T> getById(ID id);
    List<T> getAll();
    void deleteById(ID id);


    // CRUD DTOs
    D createDTO(D dto);
    List<D> getAllDTO();
    Optional<D> getDTOById(ID id);
}